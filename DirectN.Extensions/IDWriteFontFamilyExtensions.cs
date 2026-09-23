namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteFontFamilyExtensions
{
    public static IReadOnlyList<DWriteLocalizedString> GetNames(this IComObject<IDWriteFontFamily> family) => GetNames(family?.Object!);
    public static IReadOnlyList<DWriteLocalizedString> GetNames(this IDWriteFontFamily family)
    {
        ArgumentNullException.ThrowIfNull(family);
        family.GetFamilyNames(out var names).ThrowOnError();
        return names.GetNames();
    }

    public static IComObject<IDWriteFont> GetFirstMatchingFont(this IComObject<IDWriteFontFamily> family, DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL, DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL, DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL) => GetFirstMatchingFont(family?.Object!, weight, stretch, style);
    public static IComObject<IDWriteFont> GetFirstMatchingFont(this IDWriteFontFamily family, DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL, DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL, DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL)
    {
        ArgumentNullException.ThrowIfNull(family);
        family.GetFirstMatchingFont(weight, stretch, style, out var font).ThrowOnError();
        return new ComObject<IDWriteFont>(font);
    }

    public static IComObject<IDWriteFontList> GetMatchingFonts(this IComObject<IDWriteFontFamily> family, DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL, DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL, DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL) => GetMatchingFonts(family?.Object!, weight, stretch, style);
    public static IComObject<IDWriteFontList> GetMatchingFonts(this IDWriteFontFamily family, DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL, DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL, DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL)
    {
        ArgumentNullException.ThrowIfNull(family);
        family.GetMatchingFonts(weight, stretch, style, out var fonts).ThrowOnError();
        return new ComObject<IDWriteFontList>(fonts);
    }
}
