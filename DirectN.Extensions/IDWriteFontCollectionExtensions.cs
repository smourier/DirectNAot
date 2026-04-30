namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteFontCollectionExtensions
{
    public static IEnumerable<IComObject<IDWriteFontFamily>> GetFamilies(this IComObject<IDWriteFontCollection> collection) => GetFamilies(collection?.Object!).ToComObjects();
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

    public static int FindFamilyNameIndex(this IComObject<IDWriteFontCollection> collection, string name) => FindFamilyNameIndex(collection?.Object!, name);
    public static int FindFamilyNameIndex(this IDWriteFontCollection collection, string name)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(name);
        if (collection.FindFamilyName(PWSTR.From(name), out var idx, out var exists).IsError)
            return -1;

        return exists ? (int)idx : -1;
    }
}
