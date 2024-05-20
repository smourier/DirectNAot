namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteTextFormatExtensions
{
    public static string GetFontFamilyName(this IComObject<IDWriteTextFormat> format) => GetFontFamilyName(format?.Object!);
    public static string GetFontFamilyName(this IDWriteTextFormat format)
    {
        ArgumentNullException.ThrowIfNull(format);
        var len = format.GetFontFamilyNameLength();
        using var p = new AllocPwstr((len + 1) * 2);
        format.GetFontFamilyName(p, len + 1).ThrowOnError();
        return p.ToString() ?? string.Empty;
    }

    public static string GetLocaleName(this IComObject<IDWriteTextFormat> format) => GetLocaleName(format?.Object!);
    public static string GetLocaleName(this IDWriteTextFormat format)
    {
        ArgumentNullException.ThrowIfNull(format);
        var len = format.GetLocaleNameLength();
        using var p = new AllocPwstr((len + 1) * 2);
        format.GetLocaleName(p, len + 1).ThrowOnError();
        return p.ToString() ?? string.Empty;
    }

    public static IComObject<IDWriteFontCollection> GetFontCollection(this IComObject<IDWriteTextFormat> format) => GetFontCollection(format?.Object!);
    public static IComObject<IDWriteFontCollection> GetFontCollection(this IDWriteTextFormat format)
    {
        ArgumentNullException.ThrowIfNull(format);
        format.GetFontCollection(out var collection).ThrowOnError();
        return new ComObject<IDWriteFontCollection>(collection);
    }
}
