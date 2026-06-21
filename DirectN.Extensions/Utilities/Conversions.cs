namespace DirectN.Extensions.Utilities;

public static partial class Conversions
{
    private static readonly char[] _enumSeparators = [',', ';', '+', '|', ' '];
    private static readonly string[] _dateFormatsUtc = ["yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'", "yyyy'-'MM'-'dd'T'HH':'mm'Z'", "yyyyMMdd'T'HH':'mm':'ss'Z'"];

    static partial void RegisterDirectNTypes()
    {
        RegisterInputAdapter(static input =>
        {
            try
            {
                return input switch
                {
                    IValueGet vg => vg.GetValue(),
                    Variant v => v.Value,
                    PropVariant pv => pv.Value,
                    _ => null
                };
            }
            catch
            {
                return null;
            }
        });

        RegisterInputAdapter(static input =>
        {
            if (input is D3DCOLORVALUE c)
                return (c.BA == 0 ? c.ChangeAlpha(255) : c).UInt32Value;

            return null;
        });

        Register(static (object? v, ConversionOptions o, out D2D_POINT_2F r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out D2D_POINT_2U r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out POINT r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out D2D_SIZE_F r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out D2D_SIZE_U r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out SIZE r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out D2D_VECTOR_2F r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out Vector2 r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out Vector3 r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out Vector4 r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out D2D_RECT_F r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out D2D_RECT_U r) => TryChangeType(v, out r));
        Register(static (object? v, ConversionOptions o, out RECT r) => TryChangeType(v, out r));

        Register(static (object? v, ConversionOptions o, out D2D_VECTOR_3F r) =>
        {
            if (TryChangeType<Vector3>(v, CultureInfo.InvariantCulture, out var v3))
            {
                r = v3;
                return true;
            }

            r = default;
            return false;
        });

        Register(static (object? v, ConversionOptions o, out D2D_VECTOR_4F r) =>
        {
            if (TryChangeType<Vector4>(v, CultureInfo.InvariantCulture, out var v4))
            {
                r = v4;
                return true;
            }

            r = default;
            return false;
        });

        Register(static (object? v, ConversionOptions o, out D3DCOLORVALUE r) =>
        {
            if (v is string s && D3DCOLORVALUE.TryParseFromName(s, out var named))
            {
                r = named.BA == 0 ? named.ChangeAlpha(255) : named;
                return true;
            }

            if (TryConvert(v, typeof(uint), out var u, o) && u is uint ui)
            {
                var c = new D3DCOLORVALUE(ui);
                r = c.BA == 0 ? c.ChangeAlpha(255) : c;
                return true;
            }

            r = default;
            return false;
        });

        Register(static (object? v, ConversionOptions o, out OLE_COLOR r) =>
        {
            if (TryConvert(v, typeof(uint), out var u, o) && u is uint ui)
            {
                r = new OLE_COLOR(ui);
                return true;
            }

            if (TryConvert(v, typeof(D3DCOLORVALUE), out var c, o) && c is D3DCOLORVALUE clr)
            {
                r = clr.ToOLE_COLOR();
                return true;
            }

            r = default;
            return false;
        });

        Register(static (object? v, ConversionOptions o, out COLORREF r) =>
        {
            if (TryConvert(v, typeof(D3DCOLORVALUE), out var c, o) && c is D3DCOLORVALUE clr)
            {
                r = clr.ToCOLORREF();
                return true;
            }

            r = default;
            return false;
        });
    }

    public static long ToPositiveFileTime(DateTime dt)
    {
        var ft = ToFileTimeUtc(dt.ToUniversalTime());
        return ft < 0 ? 0 : ft;
    }

    public static long ToPositiveFileTimeUtc(DateTime dt)
    {
        var ft = ToFileTimeUtc(dt);
        return ft < 0 ? 0 : ft;
    }

    public static long ToFileTime(DateTime dt) => ToFileTimeUtc(dt.ToUniversalTime());
    public static long ToFileTimeUtc(DateTime dt)
    {
        const long ticksPerMillisecond = 10000;
        const long ticksPerSecond = ticksPerMillisecond * 1000;
        const long ticksPerMinute = ticksPerSecond * 60;
        const long ticksPerHour = ticksPerMinute * 60;
        const long ticksPerDay = ticksPerHour * 24;
        const int daysPerYear = 365;
        const int daysPer4Years = daysPerYear * 4 + 1;
        const int daysPer100Years = daysPer4Years * 25 - 1;
        const int daysPer400Years = daysPer100Years * 4 + 1;
        const int daysTo1601 = daysPer400Years * 4;
        const long fileTimeOffset = daysTo1601 * ticksPerDay;
        long ticks = dt.Kind == DateTimeKind.Local ? dt.ToUniversalTime().Ticks : dt.Ticks;
        ticks -= fileTimeOffset;
        return ticks;
    }

    public static FILETIME ToPositiveFILETIME(DateTime dt) => ToFILETIME(ToPositiveFileTime(dt));
    public static FILETIME ToPositiveFILETIMEUtc(DateTime dt) => ToFILETIME(ToPositiveFileTimeUtc(dt));
    public static FILETIME ToFILETIME(DateTime dt) => ToFILETIME(ToFileTime(dt));
    public static FILETIME ToFILETIMEUtc(DateTime dt) => ToFILETIME(ToFileTimeUtc(dt));
    public static FILETIME ToFILETIME(long ft) => ToFILETIME((ulong)ft);
    public static FILETIME ToFILETIME(ulong ft) => new() { dwLowDateTime = (uint)(ft & 0xFFFFFFFF), dwHighDateTime = (uint)(ft >> 32) };

    public static long ToFileTime(this FILETIME ft) => (long)(ft.dwLowDateTime | (ulong)ft.dwHighDateTime << 32);
    public static DateTime ToDateTime(this FILETIME ft) => DateTime.FromFileTime(ToFileTime(ft));
    public static DateTime ToDateTimeUtc(this FILETIME ft) => DateTime.FromFileTimeUtc(ToFileTime(ft));

    public static DateTime RemoveMilliseconds(this DateTime dateTime) => new(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Kind);
    public static DateTimeOffset RemoveMilliseconds(this DateTimeOffset dateTime) => new(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Offset);

    public static string ToHex(this byte value) => $"0x{value:X2}";
    public static string ToHex(this sbyte value) => $"0x{value:X2}";
    public static string ToHex(this ushort value) => $"0x{value:X4}";
    public static string ToHex(this short value) => $"0x{value:X4}";
    public static string ToHex(this uint value) => $"0x{value:X8}";
    public static string ToHex(this int value) => $"0x{value:X8}";
    public static string ToHex(this ulong value) => $"0x{value:X16}";
    public static string ToHex(this long value) => $"0x{value:X16}";
    public static string ToHex(this nint value)
    {
        if (IntPtr.Size == 4)
            return value.ToInt32().ToHex();

        return value.ToInt64().ToHex();
    }

    public static string ToHex(this nuint value)
    {
        if (IntPtr.Size == 4)
            return value.ToUInt32().ToHex();

        return value.ToUInt64().ToHex();
    }

    public static string ToHexa(this byte[] bytes, bool addEllipsis = false) => bytes != null ? ToHexa(bytes, 0, bytes.Length, addEllipsis) : "0x";
    public static string ToHexa(this byte[] bytes, int count, bool addEllipsis = false) => ToHexa(bytes, 0, count, addEllipsis);
    public static string ToHexa(this byte[] bytes, int offset, int count, bool addEllipsis = false)
    {
        if (bytes == null)
            return "0x";

        if (offset < 0)
            throw new ArgumentException(null, nameof(offset));

        if (count < 0)
            throw new ArgumentException(null, nameof(count));

        if (offset >= bytes.Length)
            return "0x";

        count = Math.Min(count, bytes.Length - offset);
        var sb = new StringBuilder(count * 2);
        for (var i = offset; i < (offset + count); i++)
        {
            _ = sb.Append(bytes[i].ToString("X2"));
        }

        var s = "0x" + sb.ToString();
        if (addEllipsis && bytes.Length > (offset + count))
        {
            s += "... (" + (bytes.Length - (offset + count)) + ")";
        }
        return s;
    }

    [return: NotNullIfNotNull(nameof(text))]
    public static byte[]? ToBytesFromHexa(string? text)
    {
        if (text == null)
            return null;

        var list = new List<byte>();
        var lo = false;
        byte prev = 0;
        int offset;

        if (text.Length >= 2 && text[0] == '0' && (text[1] == 'x' || text[1] == 'X'))
        {
            offset = 2;
        }
        else
        {
            offset = 0;
        }

        for (var i = 0; i < text.Length - offset; i++)
        {
            var b = GetHexaByte(text[i + offset]);
            if (b == 0xFF)
                continue;

            if (lo)
            {
                list.Add((byte)(prev * 16 + b));
            }
            else
            {
                prev = b;
            }
            lo = !lo;
        }
        return [.. list];
    }

    public static byte GetHexaByte(char c)
    {
        if (c >= '0' && c <= '9')
            return (byte)(c - '0');

        if (c >= 'A' && c <= 'F')
            return (byte)(c - 'A' + 10);

        if (c >= 'a' && c <= 'f')
            return (byte)(c - 'a' + 10);

        return 0xFF;
    }

    public static string? ToHexaDump(string text, Encoding? encoding = null)
    {
        if (text == null)
            return null;

        encoding ??= Encoding.Unicode;
        return ToHexaDump(encoding.GetBytes(text));
    }

    public static string ToHexaDump(this byte[] bytes) => ToHexaDump(bytes, null);
    public static string ToHexaDump(this byte[] bytes, string? prefix)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        return ToHexaDump(bytes, 0, bytes.Length, prefix, true);
    }

    public static string ToHexaDump(this nint ptr, int count) => ToHexaDump(ptr, 0, count, null, true);
    public static string ToHexaDump(this nint ptr, int offset, int count, string? prefix = null, bool addHeader = true)
    {
        using var writer = new StringWriter();
        WriteHexaDump(ptr, writer, offset, count, prefix, addHeader);
        return writer.ToString();
    }

    public static void WriteHexaDump(this byte[] bytes, TextWriter writer, string? prefix = null) => WriteHexaDump(bytes, writer, 0, bytes.Length, prefix, true);
    public static void WriteHexaDump(this nint ptr, TextWriter writer, int count) => WriteHexaDump(ptr, writer, 0, count, null, true);
    public static void WriteHexaDump(this nint ptr, TextWriter writer, int offset, int count, string? prefix = null, bool addHeader = true)
    {
        if (ptr == 0)
            throw new ArgumentException(null, nameof(ptr));

        var bytes = new byte[count];
        Marshal.Copy(ptr, bytes, offset, count);
        WriteHexaDump(bytes, writer, 0, count, prefix, addHeader);
    }

    public static string ToHexaDump(this byte[] bytes, int count) => ToHexaDump(bytes, 0, count, null, true);
    public static string ToHexaDump(this byte[] bytes, int offset, int count) => ToHexaDump(bytes, offset, count, null, true);
    public static string ToHexaDump(this byte[] bytes, int offset, int count, string? prefix = null, bool addHeader = true)
    {
        using var writer = new StringWriter();
        WriteHexaDump(bytes, writer, offset, count, prefix, addHeader);
        return writer.ToString();
    }

    public static void WriteHexaDump(this byte[] bytes, TextWriter writer, int count) => WriteHexaDump(bytes, writer, 0, count, null, true);
    public static void WriteHexaDump(this byte[] bytes, TextWriter writer, int offset, int count, string? prefix = null, bool addHeader = true)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        ArgumentNullException.ThrowIfNull(writer);

        if (offset < 0)
        {
            offset = 0;
        }

        if (count < 0)
        {
            count = bytes.Length;
        }

        if ((offset + count) > bytes.Length)
        {
            count = bytes.Length - offset;
        }

        if (addHeader)
        {
            writer.Write(prefix);
            //             0         1         2         3         4         5         6         7
            //             01234567890123456789012345678901234567890123456789012345678901234567890123456789
            writer.WriteLine("Offset    00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F  0123456789ABCDEF");
            writer.WriteLine("--------  -----------------------------------------------  ----------------");
        }

        for (var i = 0; i < count; i += 16)
        {
            writer.Write(prefix);
            writer.Write(string.Format("{0:X8}  ", i + offset));

            int j;
            for (j = 0; (j < 16) && ((i + j) < count); j++)
            {
                writer.Write(string.Format("{0:X2} ", bytes[i + j + offset]));
            }

            writer.Write(' ');
            if (j < 16)
            {
                writer.Write(new string(' ', 3 * (16 - j)));
            }
            for (j = 0; j < 16 && (i + j) < count; j++)
            {
                var b = bytes[i + j + offset];
                if (b > 31 && b < 128)
                {
                    writer.Write((char)b);
                }
                else
                {
                    writer.Write('.');
                }
            }

            writer.WriteLine();
        }
    }

    public static string ToHexaDump(this Span<byte> bytes, HexaDumpOptions? options = null)
        => ToHexaDump((ReadOnlySpan<byte>)bytes, options);

    public static string ToHexaDump(this ReadOnlySpan<byte> bytes, HexaDumpOptions? options = null)
    {
        using var writer = new StringWriter();
        WriteHexaDump(bytes, writer, options);
        return writer.ToString();
    }

    public static void WriteHexaDump(this Span<byte> bytes, TextWriter writer, HexaDumpOptions? options = null)
        => WriteHexaDump((ReadOnlySpan<byte>)bytes, writer, options);

    public static void WriteHexaDump(this ReadOnlySpan<byte> bytes, TextWriter writer, HexaDumpOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(writer);
        options ??= new HexaDumpOptions();

        var bytesPerLine = Math.Max(8, options.BytesPerLine);
        var byteFormatter = options.ByteFormatter ?? defaultByteFormatter;

        if (options.AddHeader)
        {
            // write something like that (16 bytes per line):
            // Offset    00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F  0123456789ABCDEF
            // --------  -----------------------------------------------  ----------------

            writer.Write(options.LinePrefix);
            writer.Write("Offset    ");
            for (var h = 0; h < bytesPerLine; h++)
            {
                writer.Write($"{h:X2} ");
            }

            for (var h = 0; h < bytesPerLine; h++)
            {
                writer.Write("0123456789ABCDEF"[h % 16]);
            }
            writer.WriteLine();

            writer.Write(options.LinePrefix);
            writer.Write("--------  ");
            for (var h = 0; h < bytesPerLine; h++)
            {
                writer.Write("---");
            }
            writer.Write("  ");
            for (var h = 0; h < bytesPerLine; h++)
            {
                writer.Write("-");
            }
            writer.WriteLine();
        }

        for (var i = 0; i < bytes.Length; i += bytesPerLine)
        {
            writer.Write(options.LinePrefix);
            writer.Write(string.Format("{0:X8}  ", options.StartOffset + i));

            int j;
            for (j = 0; (j < bytesPerLine) && ((i + j) < bytes.Length); j++)
            {
                writer.Write(string.Format("{0:X2} ", bytes[i + j]));
            }

            writer.Write(' ');
            if (j < bytesPerLine)
            {
                writer.Write(new string(' ', 3 * (bytesPerLine - j)));
            }

            for (j = 0; j < bytesPerLine && (i + j) < bytes.Length; j++)
            {
                var b = bytes[i + j];
                byteFormatter(writer, b);
            }

            writer.WriteLine();
        }

        static void defaultByteFormatter(TextWriter writer, byte b)
        {
            // writer.Write((char)(0x2400 + b)); for using unicode control pictures
            if (b > 31 && b < 128)
            {
                writer.Write((char)b);
            }
            else
            {
                writer.Write('.');
            }
        }
    }

    public static IList<string> SplitToNullifiedList(this string? text, char[] separators, int count = int.MaxValue, StringSplitOptions options = StringSplitOptions.None)
    {
        var list = new List<string>();
        if (!string.IsNullOrEmpty(text))
        {
            foreach (var str in text.Split(separators, count, options))
            {
                var s = str.Nullify();
                if (s != null)
                {
                    list.Add(s);
                }
            }
        }
        return list;
    }

    public static IList<T> SplitToList<T>(this string? text, char[] separators, IFormatProvider? provider = null, int count = int.MaxValue, StringSplitOptions options = StringSplitOptions.None)
    {
        var list = new List<T>();
        if (!string.IsNullOrEmpty(text))
        {
            foreach (var str in text.Split(separators, count, options))
            {
                var newStr = str;
                if (newStr != null && options.HasFlag(StringSplitOptions.TrimEntries))
                {
                    newStr = newStr.Trim();
                }

                if (string.IsNullOrEmpty(newStr) && options.HasFlag(StringSplitOptions.RemoveEmptyEntries))
                    continue;

                if (TryChangeType<T>(newStr, provider, out var value) && value != null)
                {
                    list.Add(value);
                }
            }
        }
        return list;
    }

    public static bool IsNullable(this Type type) { ArgumentNullException.ThrowIfNull(type); return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>); }
    public static bool IsReallyValueType(this Type type) { ArgumentNullException.ThrowIfNull(type); return type.IsValueType && !IsNullable(type); }

    public static object? ChangeObjectType(object? input, Type conversionType, object? defaultValue = null, IFormatProvider? provider = null)
    {
        if (!TryChangeObjectType(input, conversionType, provider, out object? value))
        {
            if (TryChangeObjectType(defaultValue, conversionType, provider, out var def))
                return def;

            return GetDefaultValue(conversionType);
        }
        return value;
    }

    public static T? ChangeType<T>(object? input, T? defaultValue = default, IFormatProvider? provider = null)
    {
        if (!TryChangeType(input, provider, out T? value))
            return defaultValue;

        return value;
    }

    public static bool TryChangeObjectType(object? input, Type conversionType, out object? value) => TryChangeObjectType(input, conversionType, null, out value);
    public static bool TryChangeObjectType(object? input, Type conversionType, IFormatProvider? provider, out object? value)
    {
        ArgumentNullException.ThrowIfNull(conversionType);
        if (input == null)
        {
            value = GetDefaultValue(conversionType);
            return true;
        }

        if (TryConvert(input, conversionType, out value, ToConversionOptions(provider)))
            return true;

        value = GetDefaultValue(conversionType);
        return false;
    }

    public static bool TryChangeToDateTime(object? input, DateTimeStyles styles, out DateTime value) => TryChangeToDateTime(input, null, styles, out value);
    public static bool TryChangeToDateTime(object? input, IFormatProvider? provider, DateTimeStyles styles, out DateTime value)
    {
        if (input == null)
        {
            value = DateTime.MinValue;
            return false;
        }

        if (input is long il)
        {
            if (styles.HasFlag(DateTimeStyles.AssumeLocal))
            {
                value = new DateTime(il, DateTimeKind.Local);
            }
            else
            {
                value = new DateTime(il, DateTimeKind.Utc);
            }
            return true;
        }

        if (input is double dbl)
        {
            try
            {
                value = DateTime.FromOADate(dbl);
                return true;
            }
            catch
            {
                value = DateTime.MinValue;
                return false;
            }
        }

        if (input is DateTimeOffset offset)
        {
            value = offset.DateTime;
            return true;
        }

        var text = string.Format(provider, "{0}", input).Nullify();
        if (text == null)
        {
            value = DateTime.MinValue;
            return false;
        }

        if (DateTime.TryParse(text, provider, styles, out value))
            return true;

        DateTime dt;
        // 01234567890123456
        // 20150525T15:50:00
        if (text != null && text.Length == 17)
        {
            if ((text[8] == 'T' || text[8] == 't') && text[11] == ':' && text[14] == ':')
            {
                _ = int.TryParse(text.AsSpan(0, 4), out var year);
                _ = int.TryParse(text.AsSpan(4, 2), out var month);
                _ = int.TryParse(text.AsSpan(6, 2), out var day);
                _ = int.TryParse(text.AsSpan(9, 2), out var hour);
                _ = int.TryParse(text.AsSpan(12, 2), out var minute);
                _ = int.TryParse(text.AsSpan(15, 2), out var second);
                if (month > 0 && month < 13 &&
                    day > 0 && day < 32 &&
                    year >= 0 &&
                    hour >= 0 && hour < 24 &&
                    minute >= 0 && minute < 60 &&
                    second >= 0 && second < 60)
                {
                    try
                    {
                        dt = new DateTime(year, month, day, hour, minute, second);
                        value = dt;
                        return true;
                    }
                    catch
                    {
                        // do nothing
                    }
                }
            }
        }

        if (text != null && text.EndsWith("Z", StringComparison.OrdinalIgnoreCase))
        {
            if (DateTime.TryParseExact(text, _dateFormatsUtc, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out dt))
            {
                value = dt;
                return true;
            }
        }

        if (long.TryParse(text, out var l))
        {
            if (styles.HasFlag(DateTimeStyles.AssumeLocal))
            {
                value = new DateTime(l, DateTimeKind.Local);
            }
            else
            {
                value = new DateTime(l, DateTimeKind.Utc);
            }
            return true;
        }

        if (double.TryParse(text, provider, out dbl))
        {
            try
            {
                value = DateTime.FromOADate(dbl);
                return true;
            }
            catch
            {
                value = DateTime.MinValue;
                return false;
            }
        }
        return false;
    }

    public static object ToEnum(string text, Type enumType)
    {
        ArgumentNullException.ThrowIfNull(enumType);
        _ = EnumTryParse(enumType, text, out object value);
        return value;
    }

    public static Enum ToEnum(string text, Enum defaultValue)
    {
        if (EnumTryParse(defaultValue.GetType(), text, out object value))
            return (Enum)value;

        return defaultValue;
    }

    public static object ToEnum(Type type, string text)
    {
        EnumTryParse(type, text, out var value);
        return value;
    }

    public static bool EnumTryParse(Type type, object input, out object value)
    {
        ArgumentNullException.ThrowIfNull(type);
        if (!type.IsEnum)
            throw new ArgumentException(null, nameof(type));

        if (TryConvert(input, type, out var converted, ToConversionOptions(CultureInfo.InvariantCulture)) && converted is not null)
        {
            value = converted;
            return true;
        }

        value = GetDefaultValue(type)!;
        return false;
    }

    public static ulong EnumToUInt64(object value)
    {
        var typeCode = Convert.GetTypeCode(value);
        return typeCode switch
        {
            TypeCode.SByte or TypeCode.Int16 or TypeCode.Int32 or TypeCode.Int64 => (ulong)Convert.ToInt64(value, CultureInfo.InvariantCulture),
            TypeCode.Byte or TypeCode.UInt16 or TypeCode.UInt32 or TypeCode.UInt64 => Convert.ToUInt64(value, CultureInfo.InvariantCulture),
            _ => ChangeType<ulong>(value, 0, CultureInfo.InvariantCulture),
        };
    }

    public static object EnumToObject(Type type, object value)
    {
        ArgumentNullException.ThrowIfNull(type);
        if (!type.IsEnum)
            throw new ArgumentException(null, nameof(type));

        var underlyingType = Enum.GetUnderlyingType(type);
        if (underlyingType == typeof(long))
            return Enum.ToObject(type, ChangeType<long>(value));

        if (underlyingType == typeof(ulong))
            return Enum.ToObject(type, ChangeType<ulong>(value));

        if (underlyingType == typeof(int))
            return Enum.ToObject(type, ChangeType<int>(value));

        if (underlyingType == typeof(uint))
            return Enum.ToObject(type, ChangeType<uint>(value));

        if (underlyingType == typeof(short))
            return Enum.ToObject(type, ChangeType<short>(value));

        if (underlyingType == typeof(ushort))
            return Enum.ToObject(type, ChangeType<ushort>(value));

        if (underlyingType == typeof(byte))
            return Enum.ToObject(type, ChangeType<byte>(value));

        if (underlyingType == typeof(sbyte))
            return Enum.ToObject(type, ChangeType<sbyte>(value));

        throw new NotSupportedException();
    }

    // a non-nullable value type is zero-initialized and needs no constructor, so GetUninitializedObject is provably safe here
    [UnconditionalSuppressMessage("Trimming", "IL2067", Justification = "value types are zero-initialized and require no preserved constructor")]
    private static object? GetDefaultValue(Type type) => type.IsReallyValueType() ? RuntimeHelpers.GetUninitializedObject(type) : null;

    public static bool TryChangeType(object? value, out D2D_POINT_2F point)
    {
        if (value == null)
        {
            point = D2D_POINT_2F.Zero;
            return false;
        }

        if (value is D2D_POINT_2F p2)
        {
            point = p2;
            return true;
        }

        if (value is D2D_POINT_2U pu)
        {
            point = pu;
            return true;
        }

        if (value is Vector2 v2)
        {
            point = v2;
            return true;
        }

        if (value is D2D_VECTOR_2F v)
        {
            point = v;
            return true;
        }

        if (value is POINT p)
        {
            point = p;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            point = D2D_POINT_2F.Zero;
            return true;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            point = D2D_POINT_2F.Zero;
            return false;
        }

        if (!float.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !float.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            point = D2D_POINT_2F.Zero;
            return false;
        }

        point = new D2D_POINT_2F(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out D2D_POINT_2U point)
    {
        if (value == null)
        {
            point = D2D_POINT_2U.Zero;
            return false;
        }

        if (value is D2D_POINT_2U pu)
        {
            point = pu;
            return true;
        }

        if (value is D2D_POINT_2F pf)
        {
            point = pf;
            return true;
        }

        if (value is Vector2 v2)
        {
            point = v2;
            return true;
        }

        if (value is D2D_VECTOR_2F v)
        {
            point = v;
            return true;
        }

        if (value is POINT p)
        {
            point = p;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            point = D2D_POINT_2U.Zero;
            return true;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            point = D2D_POINT_2U.Zero;
            return false;
        }

        if (!uint.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !uint.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            point = D2D_POINT_2U.Zero;
            return false;
        }

        point = new D2D_POINT_2U(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out POINT point)
    {
        if (value == null)
        {
            point = POINT.Zero;
            return false;
        }

        if (value is POINT p)
        {
            point = p;
            return true;
        }

        if (value is D2D_POINT_2U pu)
        {
            point = pu;
            return true;
        }

        if (value is D2D_POINT_2F pf)
        {
            point = pf;
            return true;
        }

        if (value is Vector2 v2)
        {
            point = v2;
            return true;
        }

        if (value is D2D_VECTOR_2F v)
        {
            point = v;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            point = POINT.Zero;
            return true;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            point = POINT.Zero;
            return false;
        }

        if (!int.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !int.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            point = POINT.Zero;
            return false;
        }

        point = new POINT(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out D2D_SIZE_F size)
    {
        if (value == null)
        {
            size = D2D_SIZE_F.Zero;
            return false;
        }

        if (value is D2D_SIZE_F s)
        {
            size = s;
            return true;
        }

        if (value is Vector2 v2)
        {
            size = v2;
            return true;
        }

        if (value is D2D_VECTOR_2F v)
        {
            size = v;
            return true;
        }

        if (value is D2D_SIZE_F sf)
        {
            size = sf;
            return true;
        }

        if (value is D2D_SIZE_U su)
        {
            size = su;
            return true;
        }

        if (value is SIZE sz)
        {
            size = sz;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            size = D2D_SIZE_F.Zero;
            return true;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            size = D2D_SIZE_F.Zero;
            return false;
        }

        if (!float.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !float.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            size = D2D_SIZE_F.Zero;
            return false;
        }

        size = new D2D_SIZE_F(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out D2D_SIZE_U size)
    {
        if (value == null)
        {
            size = D2D_SIZE_U.Zero;
            return false;
        }

        if (value is D2D_SIZE_U su)
        {
            size = su;
            return true;
        }

        if (value is Vector2 v2)
        {
            size = v2;
            return true;
        }

        if (value is D2D_VECTOR_2F v)
        {
            size = v;
            return true;
        }

        if (value is D2D_SIZE_F sf)
        {
            size = sf;
            return true;
        }

        if (value is SIZE s)
        {
            size = s;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            size = D2D_SIZE_U.Zero;
            return true;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            size = D2D_SIZE_U.Zero;
            return false;
        }

        if (!uint.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !uint.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            size = D2D_SIZE_U.Zero;
            return false;
        }

        size = new D2D_SIZE_U(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out SIZE size)
    {
        if (value == null)
        {
            size = SIZE.Zero;
            return false;
        }

        if (value is SIZE s)
        {
            size = s;
            return true;
        }

        if (value is D2D_SIZE_U su)
        {
            size = su;
            return true;
        }

        if (value is Vector2 v2)
        {
            size = v2;
            return true;
        }

        if (value is D2D_VECTOR_2F v)
        {
            size = v;
            return true;
        }

        if (value is D2D_SIZE_F sf)
        {
            size = sf;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            size = SIZE.Zero;
            return true;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            size = SIZE.Zero;
            return false;
        }

        if (!int.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !int.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            size = SIZE.Zero;
            return false;
        }

        size = new SIZE(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out D2D_VECTOR_2F vector)
    {
        if (value == null)
        {
            vector = Vector2.Zero;
            return false;
        }

        if (value is D2D_VECTOR_2F v)
        {
            vector = v;
            return true;
        }

        if (value is Vector2 v2)
        {
            vector = v2;
            return true;
        }

        if (value is D2D_POINT_2F p2)
        {
            vector = p2;
            return true;
        }

        if (value is D2D_POINT_2U pu)
        {
            vector = pu;
            return true;
        }

        if (value is POINT p)
        {
            vector = p;
            return true;
        }

        if (value is D2D_SIZE_F size)
        {
            vector = size;
            return true;
        }

        if (value is D2D_SIZE_U su)
        {
            vector = su;
            return true;
        }

        if (value is SIZE s)
        {
            vector = s;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            vector = Vector2.Zero;
            return false;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            vector = Vector2.Zero;
            return false;
        }

        if (!float.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !float.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            vector = Vector2.Zero;
            return false;
        }

        vector = new Vector2(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out Vector2 vector)
    {
        if (value == null)
        {
            vector = Vector2.Zero;
            return false;
        }

        if (value is Vector2 v2)
        {
            vector = v2;
            return true;
        }

        if (value is D2D_VECTOR_2F v)
        {
            vector = v;
            return true;
        }

        if (value is D2D_POINT_2F p2)
        {
            vector = p2;
            return true;
        }

        if (value is D2D_POINT_2U pu)
        {
            vector = pu;
            return true;
        }

        if (value is POINT p)
        {
            vector = p;
            return true;
        }

        if (value is D2D_SIZE_F size)
        {
            vector = size;
            return true;
        }

        if (value is D2D_SIZE_U su)
        {
            vector = su;
            return true;
        }

        if (value is SIZE s)
        {
            vector = s;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 3)
        {
            vector = Vector2.Zero;
            return false;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 2)
        {
            vector = Vector2.Zero;
            return false;
        }

        if (!float.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !float.TryParse(split[1], CultureInfo.InvariantCulture, out var y))
        {
            vector = Vector2.Zero;
            return false;
        }

        vector = new Vector2(x, y);
        return true;
    }

    public static bool TryChangeType(object? value, out Vector3 vector)
    {
        if (value == null)
        {
            vector = Vector3.Zero;
            return false;
        }

        if (value is Vector3 v3)
        {
            vector = v3;
            return true;
        }

        if (value is D2D_VECTOR_3F v)
        {
            vector = v;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 5)
        {
            vector = Vector3.Zero;
            return false;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 3)
        {
            vector = Vector3.Zero;
            return false;
        }

        if (!float.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !float.TryParse(split[1], CultureInfo.InvariantCulture, out var y) ||
            !float.TryParse(split[2], CultureInfo.InvariantCulture, out var z))
        {
            vector = Vector3.Zero;
            return false;
        }

        vector = new Vector3(x, y, z);
        return true;
    }

    public static bool TryChangeType(object? value, out Vector4 vector)
    {
        if (value == null)
        {
            vector = Vector4.Zero;
            return false;
        }

        if (value is Vector4 v4)
        {
            vector = v4;
            return true;
        }

        if (value is D2D_VECTOR_4F v)
        {
            vector = v;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 7)
        {
            vector = Vector4.Zero;
            return false;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 4)
        {
            vector = Vector4.Zero;
            return false;
        }

        if (!float.TryParse(split[0], CultureInfo.InvariantCulture, out var x) ||
            !float.TryParse(split[1], CultureInfo.InvariantCulture, out var y) ||
            !float.TryParse(split[2], CultureInfo.InvariantCulture, out var z) ||
            !float.TryParse(split[3], CultureInfo.InvariantCulture, out var w))
        {
            vector = Vector4.Zero;
            return false;
        }

        vector = new Vector4(x, y, z, w);
        return true;
    }

    public static bool TryChangeType(object? value, out D2D_RECT_F rect)
    {
        if (value == null)
        {
            rect = D2D_RECT_F.Zero;
            return false;
        }

        if (value is D2D_RECT_F rc)
        {
            rect = rc;
            return true;
        }

        if (value is D2D_RECT_U ru)
        {
            rect = ru;
            return true;
        }

        if (value is RECT r)
        {
            rect = r;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 7)
        {
            rect = D2D_RECT_F.Zero;
            return false;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 4)
        {
            rect = D2D_RECT_F.Zero;
            return false;
        }

        if (!float.TryParse(split[0], CultureInfo.InvariantCulture, out var left) ||
            !float.TryParse(split[1], CultureInfo.InvariantCulture, out var top) ||
            !float.TryParse(split[2], CultureInfo.InvariantCulture, out var right) ||
            !float.TryParse(split[3], CultureInfo.InvariantCulture, out var bottom))
        {
            rect = D2D_RECT_F.Zero;
            return false;
        }

        rect = new D2D_RECT_F(left, top, right, bottom);
        return true;
    }

    public static bool TryChangeType(object? value, out D2D_RECT_U rect)
    {
        if (value == null)
        {
            rect = D2D_RECT_U.Zero;
            return false;
        }

        if (value is D2D_RECT_U ru)
        {
            rect = ru;
            return true;
        }

        if (value is D2D_RECT_F rc)
        {
            rect = rc;
            return true;
        }

        if (value is RECT r)
        {
            rect = r;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 7)
        {
            rect = D2D_RECT_U.Zero;
            return false;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 4)
        {
            rect = D2D_RECT_U.Zero;
            return false;
        }

        if (!uint.TryParse(split[0], CultureInfo.InvariantCulture, out var left) ||
            !uint.TryParse(split[1], CultureInfo.InvariantCulture, out var top) ||
            !uint.TryParse(split[2], CultureInfo.InvariantCulture, out var right) ||
            !uint.TryParse(split[3], CultureInfo.InvariantCulture, out var bottom))
        {
            rect = D2D_RECT_U.Zero;
            return false;
        }

        rect = new D2D_RECT_U(left, top, right, bottom);
        return true;
    }

    public static bool TryChangeType(object? value, out RECT rect)
    {
        if (value == null)
        {
            rect = RECT.Zero;
            return false;
        }

        if (value is D2D_RECT_U ru)
        {
            rect = ru;
            return true;
        }

        if (value is D2D_RECT_F rc)
        {
            rect = rc;
            return true;
        }

        if (value is RECT r)
        {
            rect = r;
            return true;
        }

        if (!TryChangeType<string>(value, CultureInfo.InvariantCulture, out var str) || str?.Length < 7)
        {
            rect = RECT.Zero;
            return false;
        }

        var split = str!.Replace("<", string.Empty).Replace(">", string.Empty).Split([' ', ',', ';']);
        if (split.Length != 4)
        {
            rect = RECT.Zero;
            return false;
        }

        if (!int.TryParse(split[0], CultureInfo.InvariantCulture, out var left) ||
            !int.TryParse(split[1], CultureInfo.InvariantCulture, out var top) ||
            !int.TryParse(split[2], CultureInfo.InvariantCulture, out var right) ||
            !int.TryParse(split[3], CultureInfo.InvariantCulture, out var bottom))
        {
            rect = RECT.Zero;
            return false;
        }

        rect = new RECT(left, top, right, bottom);
        return true;
    }

    public static bool TryChangeType<T>(object? input, out T? value) => TryChangeType(input, null, out value);
    public static bool TryChangeType<T>(object? input, IFormatProvider? provider, out T? value)
    {
        if (!TryChangeObjectType(input, typeof(T), provider, out object? tvalue))
        {
            value = default;
            return false;
        }

        value = (T?)tvalue;
        return true;
    }

    public static string? CapitalizeFirst(this string? thisString, CultureInfo? culture = null)
    {
        if (string.IsNullOrEmpty(thisString))
            return null;

        if (culture == null)
            return char.ToUpper(thisString[0]) + thisString[1..];

        return char.ToUpper(thisString[0], culture) + thisString[1..];
    }

    public static bool IsFlagsEnum(Type enumType)
    {
        ArgumentNullException.ThrowIfNull(enumType);
        if (!enumType.IsEnum)
            throw new ArgumentException(null, nameof(enumType));

        return enumType.IsDefined(typeof(FlagsAttribute), true);
    }

    [return: NotNullIfNotNull(nameof(text))]
    public static string? Decamelize(string? text, DecamelizeOptions options = DecamelizeOptions.Default)
    {
        // input: a string like loadByWhateverStuff
        // output: a string like Load By Whatever Stuff
        // BBKing -> BBKing
        // BBOKing -> BboKing
        // LoadBy25Years -> Load By 25 Years
        // SoftFluent.PetShop -> Soft Fluent. Pet Shop
        // Data2_FileName -> Data 2 File Name
        // _WhatIs -> _What is
        // __WhatIs -> __What is
        // __What__Is -> __What is
        // MyParam1 -> My Param 1
        // MyParam1Baby -> My Param1 Baby (if DontDecamelizeNumbers)

        if (string.IsNullOrWhiteSpace(text))
            return text;

        var lastCategory = CharUnicodeInfo.GetUnicodeCategory(text[0]);
        var prevCategory = lastCategory;
        if (lastCategory == UnicodeCategory.UppercaseLetter)
        {
            lastCategory = UnicodeCategory.LowercaseLetter;
        }

        var i = 0;
        var firstIsStillUnderscore = text[0] == '_';
        var sb = new StringBuilder(text.Length);

        var separated = false;
        var cat = char.GetUnicodeCategory(text[0]);
        switch (cat)
        {
            case UnicodeCategory.ClosePunctuation:
            case UnicodeCategory.ConnectorPunctuation:
            case UnicodeCategory.DashPunctuation:
            case UnicodeCategory.EnclosingMark:
            case UnicodeCategory.FinalQuotePunctuation:
            case UnicodeCategory.Format:
            case UnicodeCategory.InitialQuotePunctuation:
            case UnicodeCategory.LineSeparator:
            case UnicodeCategory.OpenPunctuation:
            case UnicodeCategory.OtherPunctuation:
            case UnicodeCategory.ParagraphSeparator:
            case UnicodeCategory.SpaceSeparator:
            case UnicodeCategory.SpacingCombiningMark:
                separated = true;
                break;
        }

        if (options.HasFlag(DecamelizeOptions.UnescapeUnicode) && CanUnicodeEscape(text, 0))
        {
            _ = sb.Append(GetUnicodeEscape(text, ref i));
        }
        else if (options.HasFlag(DecamelizeOptions.UnescapeHexadecimal) && CanHexadecimalEscape(text, 0))
        {
            _ = sb.Append(GetHexadecimalEscape(text, ref i));
        }
        else
        {
            if (options.HasFlag(DecamelizeOptions.ForceFirstUpper))
            {
                _ = sb.Append(char.ToUpper(text[0]));
            }
            else
            {
                _ = sb.Append(text[0]);
            }
        }

        for (i++; i < text.Length; i++)
        {
            var c = text[i];
            if (options.HasFlag(DecamelizeOptions.UnescapeUnicode) && CanUnicodeEscape(text, i))
            {
                _ = sb.Append(GetUnicodeEscape(text, ref i));
                separated = true;
            }
            else if (options.HasFlag(DecamelizeOptions.UnescapeHexadecimal) && CanHexadecimalEscape(text, i))
            {
                _ = sb.Append(GetHexadecimalEscape(text, ref i));
                separated = true;
            }
            else if (c == '_')
            {
                if (!firstIsStillUnderscore || !options.HasFlag(DecamelizeOptions.KeepFirstUnderscores))
                {
                    _ = sb.Append(' ');
                    separated = true;
                }
                else
                {
                    _ = sb.Append(c);
                }
            }
            else
            {
                var category = CharUnicodeInfo.GetUnicodeCategory(c);
                switch (category)
                {
                    case UnicodeCategory.ClosePunctuation:
                    case UnicodeCategory.ConnectorPunctuation:
                    case UnicodeCategory.DashPunctuation:
                    case UnicodeCategory.EnclosingMark:
                    case UnicodeCategory.FinalQuotePunctuation:
                    case UnicodeCategory.Format:
                    case UnicodeCategory.InitialQuotePunctuation:
                    case UnicodeCategory.LineSeparator:
                    case UnicodeCategory.OpenPunctuation:
                    case UnicodeCategory.OtherPunctuation:
                    case UnicodeCategory.ParagraphSeparator:
                    case UnicodeCategory.SpaceSeparator:
                    case UnicodeCategory.SpacingCombiningMark:
                        if (options.HasFlag(DecamelizeOptions.KeepFormattingIndices) && c == '{')
                        {
                            while (c != '}')
                            {
                                c = text[i++];
                                _ = sb.Append(c);
                            }

                            i--;
                            separated = true;
                            break;
                        }

                        if (options.HasFlag(DecamelizeOptions.ForceRestLower))
                        {
                            _ = sb.Append(char.ToLower(c));
                        }
                        else
                        {
                            _ = sb.Append(c);
                        }

                        if (c != ' ' && !separated)
                        {
                            _ = sb.Append(' ');
                        }
                        separated = true;
                        break;

                    case UnicodeCategory.LetterNumber:
                    case UnicodeCategory.DecimalDigitNumber:
                    case UnicodeCategory.OtherNumber:
                    case UnicodeCategory.CurrencySymbol:
                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.MathSymbol:
                    case UnicodeCategory.ModifierLetter:
                    case UnicodeCategory.ModifierSymbol:
                    case UnicodeCategory.NonSpacingMark:
                    case UnicodeCategory.OtherLetter:
                    case UnicodeCategory.OtherNotAssigned:
                    case UnicodeCategory.Control:
                    case UnicodeCategory.OtherSymbol:
                    case UnicodeCategory.Surrogate:
                    case UnicodeCategory.PrivateUse:
                    case UnicodeCategory.TitlecaseLetter:
                    case UnicodeCategory.UppercaseLetter:
                        if (category != lastCategory && c != ' ' && IsNewCategory(category, options))
                        {
                            if (!separated && prevCategory != UnicodeCategory.UppercaseLetter &&
                                (!firstIsStillUnderscore || !options.HasFlag(DecamelizeOptions.KeepFirstUnderscores)))
                            {
                                _ = sb.Append(' ');
                            }

                            if (options.HasFlag(DecamelizeOptions.ForceRestLower))
                            {
                                _ = sb.Append(char.ToLower(c));
                            }
                            else
                            {
                                _ = sb.Append(char.ToUpper(c));
                            }

                            var upper = char.ToUpper(c);
                            category = CharUnicodeInfo.GetUnicodeCategory(upper);
                            if (category == UnicodeCategory.UppercaseLetter)
                            {
                                lastCategory = UnicodeCategory.LowercaseLetter;
                            }
                            else
                            {
                                lastCategory = category;
                            }
                        }
                        else
                        {
                            if (options.HasFlag(DecamelizeOptions.ForceRestLower))
                            {
                                _ = sb.Append(char.ToLower(c));
                            }
                            else
                            {
                                _ = sb.Append(c);
                            }
                        }
                        separated = false;
                        break;
                }

                firstIsStillUnderscore = firstIsStillUnderscore && c == '_';
                prevCategory = category;
            }
        }

        if (options.HasFlag(DecamelizeOptions.ReplaceSpacesByUnderscore))
            return sb.Replace(' ', '_').ToString();

        if (options.HasFlag(DecamelizeOptions.ReplaceSpacesByMinus))
            return sb.Replace(' ', '-').ToString();

        if (options.HasFlag(DecamelizeOptions.ReplaceSpacesByDot))
            return sb.Replace(' ', '.').ToString();

        return sb.ToString();

        // note: we don't want to use char.IsDigit nor char.IsNumber
        static bool IsAsciiNumber(char c) => c >= '0' && c <= '9';
        static bool CanUnicodeEscape(string text, int i) => (i + 5) < text.Length && text[i] == '\\' && text[i + 1] == 'u' && IsAsciiNumber(text[i + 2]) && IsAsciiNumber(text[i + 3]) && IsAsciiNumber(text[i + 4]) && IsAsciiNumber(text[i + 5]);
        static bool IsHexNumber(char c) => IsAsciiNumber(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
        static bool CanHexadecimalEscape(string text, int i) => (i + 6) < text.Length && text[i] == '_' && text[i + 1] == 'x' && text[i + 6] == '_' && IsHexNumber(text[i + 2]) && IsHexNumber(text[i + 3]) && IsHexNumber(text[i + 4]) && IsHexNumber(text[i + 5]);
        static char GetUnicodeEscape(string text, ref int i) { i += 5; return (char)int.Parse(text.Substring(2, 4)); }
        static char GetHexadecimalEscape(string text, ref int i) { i += 6; return (char)int.Parse(text.Substring(2, 4), NumberStyles.HexNumber); }
        static bool IsNewCategory(UnicodeCategory category, DecamelizeOptions options)
        {
            if (options.HasFlag(DecamelizeOptions.DontDecamelizeNumbers))
            {
                if (category == UnicodeCategory.LetterNumber ||
                    category == UnicodeCategory.DecimalDigitNumber ||
                    category == UnicodeCategory.OtherNumber)
                    return false;
            }
            return true;
        }
    }
}
