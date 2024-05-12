﻿using System.Collections;
using System.Globalization;

namespace DirectNAot.Extensions.Utilities;

public static class Extensions
{
    public static bool EqualsIgnoreCase(this string? thisString, string? text, bool trim = true)
    {
        if (trim)
        {
            thisString = thisString.Nullify();
            text = text.Nullify();
        }

        if (thisString == null)
            return text == null;

        if (text == null)
            return false;

        if (thisString.Length != text.Length)
            return false;

        return string.Compare(thisString, text, StringComparison.OrdinalIgnoreCase) == 0;
    }

    public static string? Nullify(this string? text)
    {
        if (text == null)
            return null;

        if (string.IsNullOrWhiteSpace(text))
            return null;

        var t = text.Trim();
        return t.Length == 0 ? null : t;
    }

    // we don't want unspecified datetimes
    public static bool IsValid(this DateTime dt) => dt != DateTime.MinValue && dt != DateTime.MaxValue && dt.Kind != DateTimeKind.Unspecified;
    public static bool IsValid(this DateTime? dt) => dt.HasValue && IsValid(dt.Value);

    public static DateTimeOffset ToDateTimeOffset(this FILETIME fileTime)
    {
        var ft = (((long)fileTime.dwHighDateTime) << 32) + fileTime.dwLowDateTime;
        return DateTimeOffset.FromFileTime(ft);
    }

    public static long CopyTo(this Stream input, Stream output, long count = long.MaxValue, int bufferSize = 0x14000)
    {
        ArgumentNullException.ThrowIfNull(input);
        ArgumentNullException.ThrowIfNull(output);
        if (count <= 0)
            throw new ArgumentException(null, nameof(count));

        if (bufferSize <= 0)
            throw new ArgumentException(null, nameof(bufferSize));

        if (count < bufferSize)
        {
            bufferSize = (int)count;
        }

        var bytes = new byte[bufferSize];
        var total = 0;
        do
        {
            var max = (int)Math.Min(count - total, bytes.Length);
            var read = input.Read(bytes, 0, max);
            if (read == 0)
                break;

            output.Write(bytes, 0, read);
            total += read;
            if (total == count)
                break;
        }
        while (true);
        return total;
    }

    public static void Dispose(this IEnumerable disposables, bool throwOnError = false)
    {
        if (disposables == null)
            return;

        if (throwOnError)
        {
            foreach (var disposable in disposables.OfType<IDisposable>())
            {
                disposable?.Dispose();
            }
        }
        else
        {
            foreach (var disposable in disposables.OfType<IDisposable>())
            {
                try
                {
                    disposable?.Dispose();
                }
                catch
                {
                    // continue
                }
            }
        }
    }

    public static void WithDispose(this IEnumerable disposables, Action action, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (disposables == null)
        {
            action();
            return;
        }

        try
        {
            action();
        }
        finally
        {
            if (throwOnError)
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    disposable?.Dispose();
                }
            }
            else
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    try
                    {
                        disposable?.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }
    }

    public static T WithDispose<T>(this IEnumerable disposables, Func<T> func, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (disposables == null)
            return func();

        try
        {
            return func();
        }
        finally
        {
            if (throwOnError)
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    disposable?.Dispose();
                }
            }
            else
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    try
                    {
                        disposable?.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }
    }

    public static void WithDispose(this IDisposable disposable, Action action, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (disposable == null)
        {
            action();
            return;
        }

        try
        {
            action();
        }
        finally
        {
            if (throwOnError)
            {
                disposable.Dispose();
            }
            else
            {
                try
                {
                    disposable.Dispose();
                }
                catch
                {
                    // continue
                }
            }
        }
    }

    public static T WithDispose<T>(this IDisposable disposable, Func<T> func, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (disposable == null)
            return func();

        try
        {
            return func();
        }
        finally
        {
            if (throwOnError)
            {
                disposable.Dispose();
            }
            else
            {
                try
                {
                    disposable.Dispose();
                }
                catch
                {
                    // continue
                }
            }
        }
    }

    public static object? ChangeType(this VARENUM vt, object? value)
    {
        object? changed;
        switch (vt)
        {
            case VARENUM.VT_UI1:
                changed = Conversions.ChangeType<byte>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_UI2:
                changed = Conversions.ChangeType<ushort>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_UI4:
                changed = Conversions.ChangeType<uint>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_UI8:
                changed = Conversions.ChangeType<ulong>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I1:
                changed = Conversions.ChangeType<sbyte>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I2:
                changed = Conversions.ChangeType<short>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I4:
                changed = Conversions.ChangeType<int>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I8:
                changed = Conversions.ChangeType<long>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_BOOL:
                changed = Conversions.ChangeType<bool>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_R4:
                changed = Conversions.ChangeType<float>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_R8:
                changed = Conversions.ChangeType<double>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_LPSTR:
            case VARENUM.VT_LPWSTR:
            case VARENUM.VT_BSTR:
                changed = Conversions.ChangeType<string>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_DECIMAL:
                changed = Conversions.ChangeType<decimal>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_DATE:
                changed = Conversions.ChangeType<DateTime>(value, provider: CultureInfo.InvariantCulture).ToOADate();
                break;

            case VARENUM.VT_FILETIME:
                changed = Conversions.ChangeType<DateTime>(value, provider: CultureInfo.InvariantCulture).ToFileTime();
                break;

            case VARENUM.VT_CLSID:
                changed = Conversions.ChangeType<Guid>(value, provider: CultureInfo.InvariantCulture);
                break;

            default:
                throw new NotSupportedException();
        }
        return changed;
    }
}
