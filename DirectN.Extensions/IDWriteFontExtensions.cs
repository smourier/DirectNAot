namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteFontExtensions
{
    public static IReadOnlyList<DWriteLocalizedString> GetFaceNames(this IComObject<IDWriteFont> font) => GetFaceNames(font?.Object!);
    public static IReadOnlyList<DWriteLocalizedString> GetFaceNames(this IDWriteFont font)
    {
        ArgumentNullException.ThrowIfNull(font);
        font.GetFaceNames(out var names).ThrowOnError();
        return names.GetNames();
    }

    public static IReadOnlyList<DWriteLocalizedString> GetInformationalStrings(this IComObject<IDWriteFont> font, DWRITE_INFORMATIONAL_STRING_ID id) => GetInformationalStrings(font?.Object!, id);
    public static IReadOnlyList<DWriteLocalizedString> GetInformationalStrings(this IDWriteFont font, DWRITE_INFORMATIONAL_STRING_ID id)
    {
        ArgumentNullException.ThrowIfNull(font);
        font.GetInformationalStrings(id, out var strings, out var exists).ThrowOnError();
        if (!exists || strings == null)
            return [];

        return strings.GetNames();
    }

    public static IComObject<IDWriteFontFace> CreateFontFace(this IComObject<IDWriteFont> font) => CreateFontFace(font?.Object!);
    public static IComObject<IDWriteFontFace> CreateFontFace(this IDWriteFont font)
    {
        ArgumentNullException.ThrowIfNull(font);
        font.CreateFontFace(out var face).ThrowOnError();
        return new ComObject<IDWriteFontFace>(face);
    }

    public static DWRITE_FONT_METRICS GetMetrics(this IComObject<IDWriteFont> font) => GetMetrics(font?.Object!);
    public static DWRITE_FONT_METRICS GetMetrics(this IDWriteFont font)
    {
        ArgumentNullException.ThrowIfNull(font);
        font.GetMetrics(out var metrics);
        return metrics;
    }

    public static bool HasCharacter(this IComObject<IDWriteFont> font, uint unicodeValue) => HasCharacter(font?.Object!, unicodeValue);
    public static bool HasCharacter(this IDWriteFont font, uint unicodeValue)
    {
        ArgumentNullException.ThrowIfNull(font);
        font.HasCharacter(unicodeValue, out var exists).ThrowOnError();
        return exists;
    }
}
