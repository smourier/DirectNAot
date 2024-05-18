namespace DirectNAot.Extensions.Utilities;

public static class Conversions
{
    private static readonly char[] _enumSeparators = [',', ';', '+', '|', ' '];
    private static readonly string[] _dateFormatsUtc = ["yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'", "yyyy'-'MM'-'dd'T'HH':'mm'Z'", "yyyyMMdd'T'HH':'mm':'ss'Z'"];

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
    public static FILETIME ToFILETIME(ulong ft) => new FILETIME { dwLowDateTime = (uint)(ft & 0xFFFFFFFF), dwHighDateTime = (uint)(ft >> 32) };

    public static long ToFileTime(this FILETIME ft) => (long)(ft.dwLowDateTime | (ulong)ft.dwHighDateTime << 32);
    public static DateTime ToDateTime(this FILETIME ft) => DateTime.FromFileTime(ToFileTime(ft));
    public static DateTime ToDateTimeUtc(this FILETIME ft) => DateTime.FromFileTimeUtc(ToFileTime(ft));

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
            throw new ArgumentException(null, nameof(offset));

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

    public static string ToHexaDump(this IntPtr ptr, int count) => ToHexaDump(ptr, 0, count, null, true);
    public static string ToHexaDump(this IntPtr ptr, int offset, int count, string? prefix = null, bool addHeader = true)
    {
        using var writer = new StringWriter();
        WriteHexaDump(ptr, writer, offset, count, prefix, addHeader);
        return writer.ToString();
    }

    public static void WriteHexaDump(this byte[] bytes, TextWriter writer, string? prefix = null) => WriteHexaDump(bytes, writer, 0, bytes.Length, prefix, true);
    public static void WriteHexaDump(this IntPtr ptr, TextWriter writer, int count) => WriteHexaDump(ptr, writer, 0, count, null, true);
    public static void WriteHexaDump(this IntPtr ptr, TextWriter writer, int offset, int count, string? prefix = null, bool addHeader = true)
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

    public static bool IsNullable(this Type type) { ArgumentNullException.ThrowIfNull(type); return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>); }
    public static bool IsReallyValueType(this Type type) { ArgumentNullException.ThrowIfNull(type); return type.IsValueType && !IsNullable(type); }

    public static object? ChangeType(object? input, Type conversionType, object? defaultValue, IFormatProvider? provider = null)
    {
        if (!TryChangeType(input, conversionType, provider, out object? value))
        {
            if (TryChangeType(defaultValue, conversionType, provider, out var def))
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

    public static bool TryChangeType(object? input, Type conversionType, out object? value) => TryChangeType(input, conversionType, null, out value);
    public static bool TryChangeType(object? input, Type conversionType, IFormatProvider? provider, out object? value)
    {
        ArgumentNullException.ThrowIfNull(conversionType);
        if (input == null)
        {
            value = GetDefaultValue(conversionType);
            return true;
        }

        var inputType = input.GetType();
        if (conversionType.IsAssignableFrom(inputType))
        {
            value = input;
            return true;
        }

        if (conversionType.IsNullable())
        {
            var firstType = conversionType.GetGenericArguments()[0];
            if (TryChangeType(input, firstType, provider, out object? vtValue))
            {
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
                var nt = typeof(Nullable<>).MakeGenericType(firstType);
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
                value = Activator.CreateInstance(nt, vtValue);
                return true;
            }

            value = null;
            return false;
        }

        if (conversionType.IsEnum)
            return EnumTryParse(conversionType, input, out value);

        if (inputType.IsEnum)
            return TryGetEnumValue(input, conversionType, inputType, out value);

        if (conversionType == typeof(int))
        {
            if (inputType == typeof(uint))
            {
                value = unchecked((int)(uint)input);
                return true;
            }

            if (inputType == typeof(ulong))
            {
                value = unchecked((int)(ulong)input);
                return true;
            }

            if (inputType == typeof(ushort))
            {
                value = unchecked((int)(ushort)input);
                return true;
            }

            if (inputType == typeof(byte))
            {
                value = unchecked((int)(byte)input);
                return true;
            }
        }

        if (conversionType == typeof(long))
        {
            if (inputType == typeof(uint))
            {
                value = unchecked((long)(uint)input);
                return true;
            }

            if (inputType == typeof(ulong))
            {
                value = unchecked((long)(ulong)input);
                return true;
            }

            if (inputType == typeof(ushort))
            {
                value = unchecked((long)(ushort)input);
                return true;
            }

            if (inputType == typeof(byte))
            {
                value = unchecked((long)(byte)input);
                return true;
            }

            if (inputType == typeof(TimeSpan))
            {
                value = ((TimeSpan)input).Ticks;
                return true;
            }
        }

        if (conversionType == typeof(short))
        {
            if (inputType == typeof(uint))
            {
                value = unchecked((short)(uint)input);
                return true;
            }

            if (inputType == typeof(ulong))
            {
                value = unchecked((short)(ulong)input);
                return true;
            }

            if (inputType == typeof(ushort))
            {
                value = unchecked((short)(ushort)input);
                return true;
            }

            if (inputType == typeof(byte))
            {
                value = unchecked((short)(byte)input);
                return true;
            }
        }

        if (conversionType == typeof(sbyte))
        {
            if (inputType == typeof(uint))
            {
                value = unchecked((sbyte)(uint)input);
                return true;
            }

            if (inputType == typeof(ulong))
            {
                value = unchecked((sbyte)(ulong)input);
                return true;
            }

            if (inputType == typeof(ushort))
            {
                value = unchecked((sbyte)(ushort)input);
                return true;
            }

            if (inputType == typeof(byte))
            {
                value = unchecked((sbyte)(byte)input);
                return true;
            }
        }

        if (conversionType == typeof(uint))
        {
            if (inputType == typeof(int))
            {
                value = unchecked((uint)(int)input);
                return true;
            }

            if (inputType == typeof(long))
            {
                value = unchecked((uint)(long)input);
                return true;
            }

            if (inputType == typeof(short))
            {
                value = unchecked((uint)(short)input);
                return true;
            }

            if (inputType == typeof(sbyte))
            {
                value = unchecked((uint)(sbyte)input);
                return true;
            }
        }

        if (conversionType == typeof(ulong))
        {
            if (inputType == typeof(int))
            {
                value = unchecked((ulong)(int)input);
                return true;
            }

            if (inputType == typeof(long))
            {
                value = unchecked((ulong)(long)input);
                return true;
            }

            if (inputType == typeof(short))
            {
                value = unchecked((ulong)(short)input);
                return true;
            }

            if (inputType == typeof(sbyte))
            {
                value = unchecked((ulong)(sbyte)input);
                return true;
            }
        }

        if (conversionType == typeof(ushort))
        {
            if (inputType == typeof(int))
            {
                value = unchecked((ushort)(int)input);
                return true;
            }

            if (inputType == typeof(long))
            {
                value = unchecked((ushort)(long)input);
                return true;
            }

            if (inputType == typeof(short))
            {
                value = unchecked((ushort)(short)input);
                return true;
            }

            if (inputType == typeof(sbyte))
            {
                value = unchecked((ushort)(sbyte)input);
                return true;
            }
        }

        if (conversionType == typeof(byte))
        {
            if (inputType == typeof(int))
            {
                value = unchecked((byte)(int)input);
                return true;
            }

            if (inputType == typeof(long))
            {
                value = unchecked((byte)(long)input);
                return true;
            }

            if (inputType == typeof(short))
            {
                value = unchecked((byte)(short)input);
                return true;
            }

            if (inputType == typeof(sbyte))
            {
                value = unchecked((byte)(sbyte)input);
                return true;
            }
        }

        if (conversionType == typeof(bool))
        {
            if (true.Equals(input))
            {
                value = true;
                return true;
            }

            if (false.Equals(input))
            {
                value = false;
                return true;
            }

            var svalue = string.Format(provider, "{0}", input).Nullify();
            if (svalue == null)
            {
                value = false;
                return false;
            }

            if (bool.TryParse(svalue, out bool b))
            {
                value = b;
                return true;
            }

            if (svalue.EqualsIgnoreCase("y") || svalue.EqualsIgnoreCase("yes"))
            {
                value = true;
                return true;
            }

            if (svalue.EqualsIgnoreCase("n") || svalue.EqualsIgnoreCase("no"))
            {
                value = false;
                return true;
            }

            if (TryChangeType(input, out long bl))
            {
                value = bl != 0;
                return true;
            }

            value = false;
            return false;
        }

        if (conversionType == typeof(DateTime))
        {
            if (inputType == typeof(long))
            {
                value = new DateTime((long)input, DateTimeKind.Utc);
                return true;
            }

            if (inputType == typeof(DateTimeOffset))
            {
                value = ((DateTimeOffset)input).DateTime;
                return true;
            }

            if (TryChangeToDateTime(input, provider, DateTimeStyles.None, out var dt))
            {
                value = dt;
                return true;
            }
        }

        if (conversionType == typeof(DateTimeOffset))
        {
            if (inputType == typeof(long))
            {
                value = new DateTimeOffset(new DateTime((long)input, DateTimeKind.Utc));
                return true;
            }

            if (inputType == typeof(DateTime))
            {
                var dt = (DateTime)input;
                if (dt.IsValid())
                {
                    value = new DateTimeOffset((DateTime)input);
                    return true;
                }
            }

            if (TryChangeToDateTime(input, provider, DateTimeStyles.None, out var dto))
            {
                value = new DateTimeOffset(dto);
                return true;
            }
        }

        if (conversionType == typeof(TimeSpan))
        {
            if (inputType == typeof(long))
            {
                value = new TimeSpan((long)input);
                return true;
            }

            if (inputType == typeof(DateTime))
            {
                value = ((DateTime)input).TimeOfDay;
                return true;
            }

            if (inputType == typeof(DateTimeOffset))
            {
                value = ((DateTimeOffset)input).TimeOfDay;
                return true;
            }

            if (TryChangeType(input, provider, out string? sv) && TimeSpan.TryParse(sv, provider, out var ts))
            {
                value = ts;
                return true;
            }
        }

        if (conversionType == typeof(Guid))
        {
            if (input is byte[] bytes && bytes.Length == 16)
            {
                value = new Guid(bytes);
                return true;
            }

            var svalue = string.Format(provider, "{0}", input).Nullify();
            if (svalue != null && Guid.TryParse(svalue, out Guid guid))
            {
                value = guid;
                return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(Uri))
        {
            var svalue = string.Format(provider, "{0}", input).Nullify();
            if (svalue != null && Uri.TryCreate(svalue, UriKind.RelativeOrAbsolute, out var uri))
            {
                value = uri;
                return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(IntPtr))
        {
            if (IntPtr.Size == 8)
            {
                if (TryChangeType(input, provider, out long l))
                {
                    value = new IntPtr(l);
                    return true;
                }
            }
            else if (TryChangeType(input, provider, out int i))
            {
                value = new IntPtr(i);
                return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        // in general, nothing is convertible to anything but one of these, IConvertible is 100% stupid thing
        bool isWellKnownConvertible()
        {
            return conversionType == typeof(short) || conversionType == typeof(int) ||
                conversionType == typeof(string) || conversionType == typeof(byte) ||
                conversionType == typeof(char) || conversionType == typeof(DateTime) ||
                conversionType == typeof(DBNull) || conversionType == typeof(decimal) ||
                conversionType == typeof(double) || conversionType.IsEnum ||
                conversionType == typeof(short) || conversionType == typeof(int) ||
                conversionType == typeof(long) || conversionType == typeof(sbyte) ||
                conversionType == typeof(bool) || conversionType == typeof(float) ||
                conversionType == typeof(ushort) || conversionType == typeof(uint) ||
                conversionType == typeof(ulong);
        }

        if (isWellKnownConvertible() && input is IConvertible convertible)
        {
            try
            {
                value = convertible.ToType(conversionType, provider);
                if (value is DateTime dt && !dt.IsValid())
                    return false;

                return true;
            }
            catch
            {
                // continue;
            }
        }

        if (conversionType == typeof(string))
        {
            value = string.Format(provider, "{0}", input);
            return true;
        }

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

    public static bool EnumTryParse(Type type, object input, out object value)
    {
        ArgumentNullException.ThrowIfNull(type);
        if (!type.IsEnum)
            throw new ArgumentException(null, nameof(type));

        if (input == null)
        {
            value = GetDefaultValue(type)!;
            return false;
        }

        var stringInput = string.Format(CultureInfo.InvariantCulture, "{0}", input);
        stringInput = stringInput.Nullify();
        if (stringInput == null)
        {
            value = GetDefaultValue(type)!;
            return false;
        }

        if (stringInput.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
        {
            if (ulong.TryParse(stringInput.AsSpan(2), NumberStyles.HexNumber, null, out var ulx))
            {
                value = ToEnum(ulx.ToString(CultureInfo.InvariantCulture), type);
                return true;
            }
        }

        var names = Enum.GetNames(type);
        if (names.Length == 0)
        {
            value = GetDefaultValue(type)!;
            return false;
        }

#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
        var values = Enum.GetValues(type);
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
        // some enums like System.CodeDom.MemberAttributes *are* flags but are not declared with Flags...
        if (!type.IsDefined(typeof(FlagsAttribute), true) && stringInput.IndexOfAny(_enumSeparators) < 0)
            return StringToEnum(type, names, values, stringInput, out value);

        // multi value enum
        var tokens = stringInput.Split(_enumSeparators, StringSplitOptions.RemoveEmptyEntries);
        if (tokens.Length == 0)
        {
            value = GetDefaultValue(type)!;
            return false;
        }

        ulong ul = 0;
        foreach (string tok in tokens)
        {
            var token = tok.Nullify(); // NOTE: we don't consider empty tokens as errors
            if (token == null)
                continue;

            if (!StringToEnum(type, names, values, token, out object tokenValue))
            {
                value = GetDefaultValue(type)!;
                return false;
            }

            ulong tokenUl;
            switch (Convert.GetTypeCode(tokenValue))
            {
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                    tokenUl = (ulong)Convert.ToInt64(tokenValue, CultureInfo.InvariantCulture);
                    break;

                default:
                    tokenUl = Convert.ToUInt64(tokenValue, CultureInfo.InvariantCulture);
                    break;
            }

            ul |= tokenUl;
        }
        value = Enum.ToObject(type, ul);
        return true;
    }

    private static bool StringToEnum(Type type, string[] names, Array values, string input, out object value)
    {
        for (var i = 0; i < names.Length; i++)
        {
            if (names[i].EqualsIgnoreCase(input))
            {
                value = values.GetValue(i)!;
                return true;
            }
        }

        for (var i = 0; i < values.GetLength(0); i++)
        {
            var valuei = values.GetValue(i)!;
            if (input.Length > 0 && input[0] == '-')
            {
                var ul = (long)EnumToUInt64(valuei);
                if (ul.ToString().EqualsIgnoreCase(input))
                {
                    value = valuei;
                    return true;
                }
            }
            else
            {
                var ul = EnumToUInt64(valuei);
                if (ul.ToString().EqualsIgnoreCase(input))
                {
                    value = valuei;
                    return true;
                }
            }
        }

        if (char.IsDigit(input[0]) || input[0] == '-' || input[0] == '+')
        {
            var obj = EnumToObject(type, input);
            if (obj == null)
            {
                value = GetDefaultValue(type)!;
                return false;
            }
            value = obj;
            return true;
        }

        value = GetDefaultValue(type)!;
        return false;
    }

    public static object EnumToObject(Type enumType, object value)
    {
        ArgumentNullException.ThrowIfNull(enumType);
        ArgumentNullException.ThrowIfNull(value);
        if (!enumType.IsEnum)
            throw new ArgumentException(null, nameof(enumType));

        var underlyingType = Enum.GetUnderlyingType(enumType);
        if (underlyingType == typeof(long))
            return Enum.ToObject(enumType, ChangeType<long>(value));

        if (underlyingType == typeof(ulong))
            return Enum.ToObject(enumType, ChangeType<ulong>(value));

        if (underlyingType == typeof(int))
            return Enum.ToObject(enumType, ChangeType<int>(value));

        if ((underlyingType == typeof(uint)))
            return Enum.ToObject(enumType, ChangeType<uint>(value));

        if (underlyingType == typeof(short))
            return Enum.ToObject(enumType, ChangeType<short>(value));

        if (underlyingType == typeof(ushort))
            return Enum.ToObject(enumType, ChangeType<ushort>(value));

        if (underlyingType == typeof(byte))
            return Enum.ToObject(enumType, ChangeType<byte>(value));

        if (underlyingType == typeof(sbyte))
            return Enum.ToObject(enumType, ChangeType<sbyte>(value));

        throw new ArgumentException(null, nameof(enumType));
    }

    public static ulong EnumToUInt64(object value)
    {
        ArgumentNullException.ThrowIfNull(value);
        var typeCode = Convert.GetTypeCode(value);
        switch (typeCode)
        {
            case TypeCode.SByte:
            case TypeCode.Int16:
            case TypeCode.Int32:
            case TypeCode.Int64:
                return (ulong)Convert.ToInt64(value, CultureInfo.InvariantCulture);

            case TypeCode.Byte:
            case TypeCode.UInt16:
            case TypeCode.UInt32:
            case TypeCode.UInt64:
                return Convert.ToUInt64(value, CultureInfo.InvariantCulture);

            //case TypeCode.String:
            default:
                return ChangeType<ulong>(value, 0, CultureInfo.InvariantCulture);
        }
    }

    private static bool TryGetEnumValue(object input, Type conversionType, Type inputType, out object? value)
    {
        var tc = Type.GetTypeCode(inputType);
        if (conversionType == typeof(int))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (int)input;
                    return true;

                case TypeCode.Int16:
                    value = (int)(short)input;
                    return true;

                case TypeCode.Int64:
                    value = (int)(long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (int)(uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (int)(ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (int)(ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (int)(byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (int)(sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(short))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (short)(int)input;
                    return true;

                case TypeCode.Int16:
                    value = (short)input;
                    return true;

                case TypeCode.Int64:
                    value = (short)(long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (short)(uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (short)(ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (short)(ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (short)(byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (short)(sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(long))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (long)(int)input;
                    return true;

                case TypeCode.Int16:
                    value = (long)(short)input;
                    return true;

                case TypeCode.Int64:
                    value = (long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (long)(uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (long)(ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (long)(ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (long)(byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (long)(sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(uint))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (uint)(int)input;
                    return true;

                case TypeCode.Int16:
                    value = (uint)(short)input;
                    return true;

                case TypeCode.Int64:
                    value = (uint)(long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (uint)(ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (uint)(ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (uint)(byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (uint)(sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(ushort))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (ushort)(int)input;
                    return true;

                case TypeCode.Int16:
                    value = (ushort)(short)input;
                    return true;

                case TypeCode.Int64:
                    value = (ushort)(long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (ushort)(uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (ushort)(ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (ushort)(byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (ushort)(sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(ulong))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (ulong)(int)input;
                    return true;

                case TypeCode.Int16:
                    value = (ulong)(short)input;
                    return true;

                case TypeCode.Int64:
                    value = (ulong)(long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (ulong)(uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (ulong)(ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (ulong)(byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (ulong)(sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(byte))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (byte)(int)input;
                    return true;

                case TypeCode.Int16:
                    value = (byte)(short)input;
                    return true;

                case TypeCode.Int64:
                    value = (byte)(long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (byte)(uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (byte)(ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (byte)(ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (byte)(sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        if (conversionType == typeof(sbyte))
        {
            switch (tc)
            {
                case TypeCode.Int32:
                    value = (sbyte)(int)input;
                    return true;

                case TypeCode.Int16:
                    value = (sbyte)(short)input;
                    return true;

                case TypeCode.Int64:
                    value = (sbyte)(long)input;
                    return true;

                case TypeCode.UInt32:
                    value = (sbyte)(uint)input;
                    return true;

                case TypeCode.UInt16:
                    value = (sbyte)(ushort)input;
                    return true;

                case TypeCode.UInt64:
                    value = (sbyte)(ulong)input;
                    return true;

                case TypeCode.Byte:
                    value = (sbyte)(byte)input;
                    return true;

                case TypeCode.SByte:
                    value = (sbyte)input;
                    return true;
            }

            value = GetDefaultValue(conversionType);
            return false;
        }

        value = GetDefaultValue(conversionType);
        return false;
    }

    private static object? GetDefaultValue(Type type)
    {
#pragma warning disable IL2067 // Target parameter argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The parameter of method does not have matching annotations.
        if (type.IsReallyValueType())
            return Activator.CreateInstance(type)!;
#pragma warning restore IL2067 // Target parameter argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The parameter of method does not have matching annotations.

        return null;
    }

    public static bool TryChangeType<T>(object? input, out T? value) => TryChangeType(input, null, out value);
    public static bool TryChangeType<T>(object? input, IFormatProvider? provider, out T? value)
    {
        if (!TryChangeType(input, typeof(T), provider, out object? tvalue))
        {
            value = default;
            return false;
        }

        value = (T?)tvalue;
        return true;
    }
}
