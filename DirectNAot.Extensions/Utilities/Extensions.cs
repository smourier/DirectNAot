using System.Collections;

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
}
