namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteFontCollectionExtensions
{
    public static IEnumerable<IComObject<IDWriteFontFamily>> GetFamilies(this IComObject<IDWriteFontCollection> collection) => GetFamilies(collection?.Object!).Select(f => new ComObject<IDWriteFontFamily>(f));
    public static IReadOnlyList<IDWriteFontFamily> GetFamilies(this IDWriteFontCollection collection)
    {
        ArgumentNullException.ThrowIfNull(collection);
        var list = new List<IDWriteFontFamily>((int)collection.GetFontFamilyCount());
        for (var i = 0; i < list.Capacity; i++)
        {
            collection.GetFontFamily((uint)i, out var family).ThrowOnError();
            list.Add(family);
        }
        return list;
    }
}
