using System.Buffers.Binary;

namespace DirectN.Extensions.Utilities;

public static partial class Conversions
{
    public delegate bool TryConverter<T>(object? value, ConversionOptions options, out T? result);

    private delegate bool TryConverterCore(object value, ConversionOptions options, out object? result);
    private static readonly ConcurrentDictionary<Type, TryConverterCore> _converters = new();
    private static readonly List<Func<object, object?>> _inputAdapters = [];

    static Conversions()
    {
        RegisterParsable<sbyte>();
        RegisterParsable<byte>();
        RegisterParsable<short>();
        RegisterParsable<ushort>();
        RegisterParsable<int>();
        RegisterParsable<uint>();
        RegisterParsable<long>();
        RegisterParsable<ulong>();
        RegisterParsable<nint>();
        RegisterParsable<nuint>();
        RegisterParsable<Int128>();
        RegisterParsable<UInt128>();
        RegisterParsable<Half>();
        RegisterParsable<float>();
        RegisterParsable<double>();
        RegisterParsable<decimal>();
        RegisterParsable<BigInteger>();
        RegisterParsable<Guid>();
        RegisterParsable<DateOnly>();
        RegisterParsable<TimeOnly>();

        Register(static (object? value, ConversionOptions options, out bool result) => TryParseBoolean(value, options, out result));
        Register(static (object? value, ConversionOptions options, out DateTime result) => TryParseDateTime(value, options, out result));
        Register(static (object? value, ConversionOptions options, out DateTimeOffset result) => TryParseDateTimeOffset(value, options, out result));
        Register(static (object? value, ConversionOptions options, out TimeSpan result) => TryParseTimeSpan(value, options, out result));

        Register(static (object? value, ConversionOptions options, out Version? result) =>
        {
            if (value is string s)
                return Version.TryParse(s, out result);

            result = null;
            return false;
        });

        Register(static (object? value, ConversionOptions options, out Uri? result) => Uri.TryCreate(value as string, UriKind.RelativeOrAbsolute, out result));

        RegisterNumeric(2, static n => new Vector2((float)n[0], (float)n[1]));
        RegisterNumeric(3, static n => new Vector3((float)n[0], (float)n[1], (float)n[2]));
        RegisterNumeric(4, static n => new Vector4((float)n[0], (float)n[1], (float)n[2], (float)n[3]));
        RegisterNumeric(4, static n => new Quaternion((float)n[0], (float)n[1], (float)n[2], (float)n[3]));
        RegisterNumeric(4, static n => new Plane((float)n[0], (float)n[1], (float)n[2], (float)n[3]));
        RegisterNumeric(2, static n => new Complex(n[0], n[1]));

        RegisterDirectNTypes();
    }

    static partial void RegisterDirectNTypes();

    public static void RegisterInputAdapter(Func<object, object?> adapter)
    {
        ArgumentNullException.ThrowIfNull(adapter);
        _inputAdapters.Add(adapter);
    }

    public static void RegisterParsable<T>() where T : IParsable<T>
        => AddConverter(typeof(T), static (value, options, out result) =>
        {
            if (value is string s && T.TryParse(s, options.FormatProvider, out var v))
            {
                result = v;
                return true;
            }

            result = null;
            return false;
        });

    public static void RegisterUtf8Parsable<T>() where T : IUtf8SpanParsable<T>
        => AddConverter(typeof(T), static (value, options, out result) =>
        {
            ReadOnlySpan<byte> utf8;
            switch (value)
            {
                case byte[] a:
                    utf8 = a;
                    break;

                case ReadOnlyMemory<byte> m:
                    utf8 = m.Span;
                    break;

                case Memory<byte> m:
                    utf8 = m.Span;
                    break;

                default:
                    result = null;
                    return false;
            }

            if (T.TryParse(utf8, options.FormatProvider, out var v))
            {
                result = v;
                return true;
            }

            result = null;
            return false;
        });

    private static void RegisterNumeric<T>(int count, Func<double[], T> factory) where T : struct
        => Register((object? value, ConversionOptions options, out T result) =>
        {
            if (value is string s && TryExtractNumbers(s, options.FormatProvider, count, out var numbers))
            {
                result = factory(numbers);
                return true;
            }

            result = default;
            return false;
        });

    public static void Register<T>(TryConverter<T> converter)
    {
        ArgumentNullException.ThrowIfNull(converter);
        AddConverter(typeof(T), (value, options, out result) =>
        {
            if (converter(value, options, out var typed))
            {
                result = typed;
                return true;
            }

            result = null;
            return false;
        });
    }

    public static bool Unregister<T>() => _converters.TryRemove(typeof(T), out _);
    public static bool TryChangeType<T>(object? value, out T? result, ConversionOptions options)
    {
        try
        {
            if (TryConvert(value, typeof(T), out var boxed, options))
            {
                result = boxed is null ? default : (T?)boxed;
                return true;
            }
        }
        catch
        {
            // continue
        }

        result = default;
        return false;
    }

    public static bool TryConvert(object? value, Type targetType, out object? result, ConversionOptions? options = null)
    {
        result = null;
        if (targetType is null)
            return false;

        options ??= ConversionOptions.Default;
        var underlying = Nullable.GetUnderlyingType(targetType) ?? targetType;
        var isNullable = !targetType.IsValueType || Nullable.GetUnderlyingType(targetType) is not null;
        if (value is null || value is DBNull)
            return isNullable;

        try
        {
            if (TryConvertCore(value, underlying, options, out result))
                return true;

            for (var guard = 0; _inputAdapters.Count > 0 && guard < 8; guard++)
            {
                var inner = Unwrap(value!);
                if (inner is null)
                    break;

                value = inner;
                if (value is null || value is DBNull)
                    return isNullable;

                if (TryConvertCore(value, underlying, options, out result))
                    return true;
            }
        }
        catch
        {
            result = null;
            return false;
        }

        return false;
    }

    private static bool TryConvertCore(object value, Type underlying, ConversionOptions options, out object? result)
    {
        result = null;

        if (underlying.IsInstanceOfType(value))
        {
            result = value;
            return true;
        }

        if (options.ByteArrayConversions)
        {
            if (value is byte[] sourceBytes)
            {
                if (underlying == typeof(string) && !options.ByteArrayAsText && options.ByteArrayStringFormat != ByteArrayStringFormat.None)
                {
                    result = FormatBytes(sourceBytes, options);
                    return true;
                }

                if (options.ByteArrayAsText)
                {
                    value = Encoding.UTF8.GetString(sourceBytes);
                }
                else if (TryFromBytes(sourceBytes, underlying, options, out result))
                {
                    return true;
                }
            }

            if (underlying == typeof(byte[]))
            {
                if (value is string s && options.ByteArrayStringFormat != ByteArrayStringFormat.None && TryParseBytes(s, options, out result))
                    return true;

                if (value is not byte[] && TryToBytes(value, options, out result))
                    return true;
            }
        }

        if (underlying.IsEnum)
            return TryParseEnum(underlying, value, options, out result);

        if (_converters.TryGetValue(underlying, out var converter) && converter(value, options, out result))
            return true;

        if (underlying == typeof(char))
            return TryConvertToChar(value, options, out result);

        if (IsNumberType(underlying))
            return TryCoerceNumber(value, underlying, options, out result);

        if (underlying == typeof(string))
        {
            result = string.Format(options.FormatProvider, "{0}", value);
            return true;
        }

        return false;
    }

    public static bool TryParse<T>(ReadOnlySpan<char> text, out T? result, ConversionOptions? options = null) where T : ISpanParsable<T> => T.TryParse(text, (options ?? ConversionOptions.Default).FormatProvider, out result);
    public static bool TryParseUtf8<T>(ReadOnlySpan<byte> utf8, out T? result, ConversionOptions? options = null) where T : IUtf8SpanParsable<T> => T.TryParse(utf8, (options ?? ConversionOptions.Default).FormatProvider, out result);

    private static object? Unwrap(object value)
    {
        foreach (var adapter in _inputAdapters)
        {
            var inner = adapter(value);
            if (inner is not null && !Equals(inner, value))
                return inner;
        }

        return null;
    }

    private static ConversionOptions ToConversionOptions(IFormatProvider? provider)
        => provider is null ? ConversionOptions.Default : new ConversionOptions { Provider = provider };

    private static bool TryParseEnum(Type enumType, object value, ConversionOptions options, out object? result)
    {
        result = null;
        if (value is string s)
        {
            s = s.Trim();
            if (s.Length == 0)
                return false;

            if (!options.LenientEnums)
                return Enum.TryParse(enumType, s, ignoreCase: true, out result);

            var tokens = s.Split(_enumSeparators, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (tokens.Length == 0)
                return false;

            if (tokens.Length == 1)
                return TryParseEnumToken(enumType, tokens[0], out result);

            ulong acc = 0;
            foreach (var token in tokens)
            {
                if (!TryParseEnumToken(enumType, token, out var part) || part is null)
                    return false;

                acc |= EnumToUInt64(part);
            }

            result = Enum.ToObject(enumType, acc);
            return true;
        }

        if (TryCoerceNumber(value, Enum.GetUnderlyingType(enumType), options, out var underlyingValue) && underlyingValue is not null)
        {
            result = Enum.ToObject(enumType, underlyingValue);
            return true;
        }

        return false;
    }

    private static bool TryParseEnumToken(Type enumType, string token, out object? result)
    {
        if (token.StartsWith("0x", StringComparison.OrdinalIgnoreCase) &&
            ulong.TryParse(token.AsSpan(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hex))
        {
            result = Enum.ToObject(enumType, hex);
            return true;
        }

        return Enum.TryParse(enumType, token, ignoreCase: true, out result);
    }

    private static bool TryParseBoolean(object? value, ConversionOptions options, out bool result)
    {
        result = false;
        if (value is bool b)
        {
            result = b;
            return true;
        }

        var text = string.Format(options.FormatProvider, "{0}", value).Nullify();
        if (text != null)
        {
            if (bool.TryParse(text, out result))
                return true;

            if (options.LenientBooleans)
            {
                switch (text.ToLowerInvariant())
                {
                    case "y":
                    case "yes":
                    case "on":
                    case "1":
                        result = true;
                        return true;

                    case "n":
                    case "no":
                    case "off":
                    case "0":
                        result = false;
                        return true;
                }
            }
        }

        if (options.LenientBooleans && value is not null && IsNumber(value) && TryCoerceNumber(value, typeof(double), options, out var d) && d is double dd)
        {
            result = dd != 0;
            return true;
        }

        return false;
    }

    private static bool TryParseDateTime(object? value, ConversionOptions options, out DateTime result)
    {
        result = default;
        var provider = options.FormatProvider;
        var styles = options.DateTimeStyles;
        var assumeLocal = styles.HasFlag(DateTimeStyles.AssumeLocal);

        switch (value)
        {
            case DateTime dt:
                result = dt;
                return true;

            case DateTimeOffset dto:
                result = dto.DateTime;
                return true;

            case long l when options.DateTimeTicks:
                result = new DateTime(l, assumeLocal ? DateTimeKind.Local : DateTimeKind.Utc);
                return true;

            case double oa when options.LenientDateTime:
                return TryFromOADate(oa, out result);
        }

        var text = string.Format(provider, "{0}", value).Nullify();
        if (text == null)
            return false;

        if (DateTime.TryParse(text, provider, styles, out result))
            return true;

        if (options.LenientDateTime)
        {
            if ((text.EndsWith('Z') || text.EndsWith('z')) &&
                DateTime.TryParseExact(text, _dateFormatsUtc, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out result))
                return true;

            if (DateTime.TryParseExact(text, "yyyyMMdd'T'HH':'mm':'ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                return true;

            if (double.TryParse(text, NumberStyles.Float, provider, out var dbl) && TryFromOADate(dbl, out result))
                return true;
        }

        if (options.DateTimeTicks && long.TryParse(text, NumberStyles.Integer, provider, out var ticks))
        {
            result = new DateTime(ticks, assumeLocal ? DateTimeKind.Local : DateTimeKind.Utc);
            return true;
        }

        return false;
    }

    private static bool TryParseDateTimeOffset(object? value, ConversionOptions options, out DateTimeOffset result)
    {
        result = default;
        switch (value)
        {
            case DateTimeOffset dto:
                result = dto;
                return true;

            case DateTime dt:
                result = new DateTimeOffset(dt.Kind == DateTimeKind.Unspecified ? DateTime.SpecifyKind(dt, DateTimeKind.Utc) : dt);
                return true;

            case long l when options.DateTimeTicks:
                result = new DateTimeOffset(new DateTime(l, DateTimeKind.Utc));
                return true;
        }

        var text = string.Format(options.FormatProvider, "{0}", value).Nullify();
        if (text != null && DateTimeOffset.TryParse(text, options.FormatProvider, options.DateTimeStyles, out result))
            return true;

        if (TryParseDateTime(value, options, out var dt2))
        {
            result = new DateTimeOffset(dt2.Kind == DateTimeKind.Unspecified ? DateTime.SpecifyKind(dt2, DateTimeKind.Utc) : dt2);
            return true;
        }

        return false;
    }

    private static bool TryParseTimeSpan(object? value, ConversionOptions options, out TimeSpan result)
    {
        result = default;
        switch (value)
        {
            case TimeSpan ts:
                result = ts;
                return true;

            case long l when options.DateTimeTicks:
                result = new TimeSpan(l);
                return true;

            case DateTime dt:
                result = dt.TimeOfDay;
                return true;

            case DateTimeOffset dto:
                result = dto.TimeOfDay;
                return true;
        }

        var text = string.Format(options.FormatProvider, "{0}", value).Nullify();
        if (text != null && TimeSpan.TryParse(text, options.FormatProvider, out result))
            return true;

        if (options.DateTimeTicks && text != null && long.TryParse(text, NumberStyles.Integer, options.FormatProvider, out var ticks))
        {
            result = new TimeSpan(ticks);
            return true;
        }

        return false;
    }

    private static bool TryFromOADate(double value, out DateTime result)
    {
        if (value < -657435.0 || value > 2958465.99999999)
        {
            result = default;
            return false;
        }

        result = DateTime.FromOADate(value);
        return true;
    }

    private static bool TryConvertToChar(object value, ConversionOptions options, out object? result)
    {
        result = null;
        if (value is string s)
        {
            if (s.Length != 1)
                return false;

            result = s[0];
            return true;
        }

        if (TryCoerceNumber(value, typeof(ushort), options, out var u) && u is ushort us)
        {
            result = (char)us;
            return true;
        }

        return false;
    }

    private static bool TryCoerceNumber(object value, Type target, ConversionOptions options, out object? result)
    {
        result = null;

        if (!options.DateTimeTicks && value is DateTime or TimeSpan or DateTimeOffset)
            return false;

        if (value is Enum)
            value = System.Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), CultureInfo.InvariantCulture);

        if (options.RoundFloatingToInteger && IsIntegerType(target) && value is float or double or decimal or Half)
            value = RoundToWhole(value);

        var truncate = options.TruncateOverflow;
        if (target == typeof(byte)) return TryCreate<byte>(value, truncate, out result);
        if (target == typeof(sbyte)) return TryCreate<sbyte>(value, truncate, out result);
        if (target == typeof(short)) return TryCreate<short>(value, truncate, out result);
        if (target == typeof(ushort)) return TryCreate<ushort>(value, truncate, out result);
        if (target == typeof(int)) return TryCreate<int>(value, truncate, out result);
        if (target == typeof(uint)) return TryCreate<uint>(value, truncate, out result);
        if (target == typeof(long)) return TryCreate<long>(value, truncate, out result);
        if (target == typeof(ulong)) return TryCreate<ulong>(value, truncate, out result);
        if (target == typeof(nint)) return TryCreate<nint>(value, truncate, out result);
        if (target == typeof(nuint)) return TryCreate<nuint>(value, truncate, out result);
        if (target == typeof(float)) return TryCreate<float>(value, truncate, out result);
        if (target == typeof(double)) return TryCreate<double>(value, truncate, out result);
        if (target == typeof(decimal)) return TryCreate<decimal>(value, truncate, out result);
        if (target == typeof(Half)) return TryCreate<Half>(value, truncate, out result);
        if (target == typeof(Int128)) return TryCreate<Int128>(value, truncate, out result);
        if (target == typeof(UInt128)) return TryCreate<UInt128>(value, truncate, out result);
        return false;
    }

    private static bool TryCreate<TTarget>(object value, bool truncate, out object? result)
        where TTarget : INumberBase<TTarget>
    {
        result = value switch
        {
            byte v => make(v),
            sbyte v => make(v),
            short v => make(v),
            ushort v => make(v),
            int v => make(v),
            uint v => make(v),
            long v => make(v),
            ulong v => make(v),
            nint v => make(v),
            nuint v => make(v),
            float v => make(v),
            double v => make(v),
            decimal v => make(v),
            Half v => make(v),
            Int128 v => make(v),
            UInt128 v => make(v),
            char v => make((ushort)v),
            bool v => v ? TTarget.One : TTarget.Zero,
            DateTime v => make(v.Ticks),
            TimeSpan v => make(v.Ticks),
            DateTimeOffset v => make(v.Ticks),
            _ => null
        };
        return result is not null;

        object make<TSource>(TSource s) where TSource : INumberBase<TSource>
            => (truncate ? TTarget.CreateTruncating(s) : TTarget.CreateChecked(s))!;
    }

    private static bool TryFromBytes(byte[] bytes, Type target, ConversionOptions options, out object? result)
    {
        result = null;
        var be = options.ByteArrayBigEndian;

        if (target == typeof(Guid))
        {
            if (bytes.Length != 16)
                return false;

            result = new Guid(bytes);
            return true;
        }

        if (bytes.Length >= 1)
        {
            if (target == typeof(byte))
            {
                result = bytes[0];
                return true;
            }

            if (target == typeof(sbyte))
            {
                result = (sbyte)bytes[0];
                return true;
            }
        }

        var size = ByteSize(target);
        if (size <= 0 || bytes.Length < size)
            return false;

        var span = bytes.AsSpan(0, size);
        result = target switch
        {
            _ when target == typeof(short) => be ? BinaryPrimitives.ReadInt16BigEndian(span) : BinaryPrimitives.ReadInt16LittleEndian(span),
            _ when target == typeof(ushort) => be ? BinaryPrimitives.ReadUInt16BigEndian(span) : BinaryPrimitives.ReadUInt16LittleEndian(span),
            _ when target == typeof(char) => (char)(be ? BinaryPrimitives.ReadUInt16BigEndian(span) : BinaryPrimitives.ReadUInt16LittleEndian(span)),
            _ when target == typeof(int) => be ? BinaryPrimitives.ReadInt32BigEndian(span) : BinaryPrimitives.ReadInt32LittleEndian(span),
            _ when target == typeof(uint) => be ? BinaryPrimitives.ReadUInt32BigEndian(span) : BinaryPrimitives.ReadUInt32LittleEndian(span),
            _ when target == typeof(long) => be ? BinaryPrimitives.ReadInt64BigEndian(span) : BinaryPrimitives.ReadInt64LittleEndian(span),
            _ when target == typeof(ulong) => be ? BinaryPrimitives.ReadUInt64BigEndian(span) : BinaryPrimitives.ReadUInt64LittleEndian(span),
            _ when target == typeof(Half) => be ? BinaryPrimitives.ReadHalfBigEndian(span) : BinaryPrimitives.ReadHalfLittleEndian(span),
            _ when target == typeof(float) => be ? BinaryPrimitives.ReadSingleBigEndian(span) : BinaryPrimitives.ReadSingleLittleEndian(span),
            _ when target == typeof(double) => be ? BinaryPrimitives.ReadDoubleBigEndian(span) : BinaryPrimitives.ReadDoubleLittleEndian(span),
            _ => null
        };
        return result is not null;
    }

    private static bool TryToBytes(object value, ConversionOptions options, out object? result)
    {
        result = null;

        if (value is Guid g)
        {
            result = g.ToByteArray();
            return true;
        }

        if (value is byte b)
        {
            result = new[] { b };
            return true;
        }

        if (value is sbyte sb)
        {
            result = new[] { (byte)sb };
            return true;
        }

        var size = ByteSize(value.GetType());
        if (size <= 0)
            return false;

        var bytes = new byte[size];
        var span = bytes.AsSpan();

        switch (value)
        {
            case short v:
                BinaryPrimitives.WriteInt16LittleEndian(span, v);
                break;

            case ushort v:
                BinaryPrimitives.WriteUInt16LittleEndian(span, v);
                break;

            case char v:
                BinaryPrimitives.WriteUInt16LittleEndian(span, v);
                break;

            case int v:
                BinaryPrimitives.WriteInt32LittleEndian(span, v);
                break;

            case uint v:
                BinaryPrimitives.WriteUInt32LittleEndian(span, v);
                break;

            case long v:
                BinaryPrimitives.WriteInt64LittleEndian(span, v);
                break;

            case ulong v:
                BinaryPrimitives.WriteUInt64LittleEndian(span, v);
                break;

            case Half v:
                BinaryPrimitives.WriteHalfLittleEndian(span, v);
                break;

            case float v:
                BinaryPrimitives.WriteSingleLittleEndian(span, v);
                break;

            case double v:
                BinaryPrimitives.WriteDoubleLittleEndian(span, v);
                break;

            default:
                return false;
        }

        if (options.ByteArrayBigEndian)
        {
            Array.Reverse(bytes);
        }

        result = bytes;
        return true;
    }

    private static string FormatBytes(byte[] bytes, ConversionOptions options) => options.ByteArrayStringFormat switch
    {
        ByteArrayStringFormat.Base64 => System.Convert.ToBase64String(bytes),
        _ => HexPrefixString(options.ByteArrayHexPrefix) + System.Convert.ToHexString(bytes)
    };

    private static string HexPrefixString(HexPrefix prefix) => prefix switch
    {
        HexPrefix.ZeroX => "0x",
        HexPrefix.ZeroXUpper => "0X",
        HexPrefix.X => "x",
        HexPrefix.XUpper => "X",
        _ => string.Empty
    };

    private static bool TryParseBytes(string text, ConversionOptions options, out object? result)
    {
        result = null;
        if (options.ByteArrayStringFormat == ByteArrayStringFormat.Base64)
        {
            var buffer = new byte[(text.Length / 4 + 1) * 3];
            if (System.Convert.TryFromBase64String(text, buffer, out var written))
            {
                result = written == buffer.Length ? buffer : buffer[..written];
                return true;
            }

            return false;
        }

        if (TryParseHex(text, out var bytes))
        {
            result = bytes;
            return true;
        }

        return false;
    }

    private static bool TryParseHex(string text, out byte[] result)
    {
        result = [];
        var span = text.AsSpan().Trim();

        if (span.Length >= 2 && span[0] == '0' && (span[1] == 'x' || span[1] == 'X'))
        {
            span = span[2..];
        }
        else if (span.Length >= 1 && (span[0] == 'x' || span[0] == 'X'))
        {
            span = span[1..];
        }

        if ((span.Length & 1) != 0)
            return false;

        var bytes = new byte[span.Length / 2];
        for (var i = 0; i < bytes.Length; i++)
        {
            var hi = HexNibble(span[i * 2]);
            var lo = HexNibble(span[i * 2 + 1]);
            if (hi == 0xFF || lo == 0xFF)
                return false;

            bytes[i] = (byte)((hi << 4) | lo);
        }

        result = bytes;
        return true;
    }

    private static bool TryExtractNumbers(string text, IFormatProvider provider, int count, out double[] numbers)
    {
        numbers = [];
        var dec = NumberFormatInfo.GetInstance(provider).NumberDecimalSeparator is { Length: > 0 } s ? s[0] : '.';
        var list = new List<double>(count);
        var i = 0;
        while (i < text.Length)
        {
            if (!IsNumberChar(text[i], dec))
            {
                i++;
                continue;
            }

            var start = i;
            while (i < text.Length && IsNumberChar(text[i], dec))
            {
                i++;
            }

            if (!double.TryParse(text.AsSpan(start, i - start), NumberStyles.Float, provider, out var value))
                return false;

            list.Add(value);
        }

        if (list.Count != count)
            return false;

        numbers = [.. list];
        return true;
    }

    private static bool IsNumberChar(char c, char decimalSeparator)
        => (c >= '0' && c <= '9') || c == '+' || c == '-' || c == 'e' || c == 'E' || c == decimalSeparator;

    private static byte HexNibble(char c)
    {
        if (c >= '0' && c <= '9')
            return (byte)(c - '0');

        if (c >= 'A' && c <= 'F')
            return (byte)(c - 'A' + 10);

        if (c >= 'a' && c <= 'f')
            return (byte)(c - 'a' + 10);

        return 0xFF;
    }

    private static int ByteSize(Type t)
    {
        if (t == typeof(short) || t == typeof(ushort) || t == typeof(char) || t == typeof(Half))
            return 2;

        if (t == typeof(int) || t == typeof(uint) || t == typeof(float))
            return 4;

        if (t == typeof(long) || t == typeof(ulong) || t == typeof(double))
            return 8;

        return 0;
    }

    private static bool IsNumber(object value)
        => value is byte or sbyte or short or ushort or int or uint or long or ulong or nint or nuint or float or double or decimal or Half or Int128 or UInt128 or char;

    private static bool IsNumberType(Type t)
        => t == typeof(byte) || t == typeof(sbyte) || t == typeof(short) || t == typeof(ushort)
        || t == typeof(int) || t == typeof(uint) || t == typeof(long) || t == typeof(ulong)
        || t == typeof(nint) || t == typeof(nuint) || t == typeof(float) || t == typeof(double)
        || t == typeof(decimal) || t == typeof(Half) || t == typeof(Int128) || t == typeof(UInt128);

    private static bool IsIntegerType(Type t)
        => t == typeof(byte) || t == typeof(sbyte) || t == typeof(short) || t == typeof(ushort)
        || t == typeof(int) || t == typeof(uint) || t == typeof(long) || t == typeof(ulong)
        || t == typeof(nint) || t == typeof(nuint) || t == typeof(Int128) || t == typeof(UInt128);

    private static object RoundToWhole(object value) => value switch
    {
        float f => Math.Round((double)f, MidpointRounding.ToEven),
        double d => Math.Round(d, MidpointRounding.ToEven),
        decimal m => Math.Round(m, MidpointRounding.ToEven),
        Half h => Math.Round((double)h, MidpointRounding.ToEven),
        _ => value
    };

    private static void AddConverter(Type type, TryConverterCore converter)
        => _converters.AddOrUpdate(
            type,
            converter,
            (_, existing) =>
            {
                return (value, options, out result) =>
                {
                    if (converter(value, options, out result))
                        return true;

                    return existing(value, options, out result);
                };
            });
}
