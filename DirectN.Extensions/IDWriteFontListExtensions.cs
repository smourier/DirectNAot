namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteFontListExtensions
{
    public static IComObject<IDWriteFont> GetFont(this IComObject<IDWriteFontList> list, uint index) => GetFont(list?.Object!, index);
    public static IComObject<IDWriteFont> GetFont(this IDWriteFontList list, uint index)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.GetFont(index, out var font).ThrowOnError();
        return new ComObject<IDWriteFont>(font);
    }

    public static IEnumerable<IComObject<IDWriteFont>> GetFonts(this IComObject<IDWriteFontList> list) => GetFonts(list?.Object!);
    public static IEnumerable<IComObject<IDWriteFont>> GetFonts(this IDWriteFontList list)
    {
        ArgumentNullException.ThrowIfNull(list);
        var count = list.GetFontCount();
        for (var i = 0u; i < count; i++)
        {
            yield return GetFont(list, i);
        }
    }
}
