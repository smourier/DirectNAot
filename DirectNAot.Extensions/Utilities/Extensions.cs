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
}
