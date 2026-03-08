namespace DirectN.Extensions;

[SupportedOSPlatform("windows10.0.10240")]
public static class IDWriteFontSetExtensions
{
    public static uint GetFontCount(this IComObject<IDWriteFontSet> set) => GetFontCount(set?.Object!);
    public static uint GetFontCount(this IDWriteFontSet set)
    {
        ArgumentNullException.ThrowIfNull(set);
        return set.GetFontCount();
    }

    public static IReadOnlyList<DWriteFont> GetFonts(this IComObject<IDWriteFontSet> set, Func<IComObject<IDWriteFontFaceReference>, DWriteFont?>? creator = null) => GetFonts(set?.Object!, creator);
    public static IReadOnlyList<DWriteFont> GetFonts(this IDWriteFontSet set, Func<IComObject<IDWriteFontFaceReference>, DWriteFont?>? creator = null)
    {
        ArgumentNullException.ThrowIfNull(set);
        var count = set.GetFontCount();
        var list = new List<DWriteFont>((int)count);
        creator ??= (co) => new DWriteFont(co);
        for (uint i = 0; i < count; i++)
        {
            set.GetFontFaceReference(i, out var fontRef).ThrowOnError();
            var co = new ComObject<IDWriteFontFaceReference>(fontRef);
            var font = creator(co);
            if (font != null)
            {
                list.Add(font);

                foreach (var id in Enum.GetValues<DWRITE_FONT_PROPERTY_ID>())
                {
                    if (id == DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_NONE)
                        continue;

                    if (set.GetPropertyValues(i, id, out var exists, out var stringsObj).IsSuccess && exists)
                    {
                        using var strings = new ComObject<IDWriteLocalizedStrings>(stringsObj);
                        var names = strings.GetNames();
                        font.Properties[id] = names;

                        if (id == DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_FULL_NAME && names.Count > 0)
                        {
                            string? name;
                            if (names.Count == 1)
                            {
                                name = names[0].String;
                            }
                            else
                            {
                                // favor english name if multiple are present
                                name = names.FirstOrDefault(n => n.LocaleName.EqualsIgnoreCase("en-us"))?.String;
                                if (string.IsNullOrWhiteSpace(name))
                                {
                                    name = names.FirstOrDefault(n => !string.IsNullOrWhiteSpace(n.String))?.String;
                                }
                            }

                            if (!string.IsNullOrWhiteSpace(name))
                            {
                                font.FullName = name;
                            }
                        }
                    }
                }
            }
        }
        return list;
    }

    public static IReadOnlyList<DWriteLocalizedString> GetPropertyValues(this IComObject<IDWriteFontSet> set, DWRITE_FONT_PROPERTY_ID id) => GetPropertyValues(set?.Object!, id);
    public static IReadOnlyList<DWriteLocalizedString> GetPropertyValues(this IDWriteFontSet set, DWRITE_FONT_PROPERTY_ID id)
    {
        ArgumentNullException.ThrowIfNull(set);
        set.GetPropertyValues(id, out var list);
        return list.GetNames();
    }

    public static IReadOnlyList<DWriteLocalizedString> GetPropertyValues(this IDWriteFontSet set, uint index, DWRITE_FONT_PROPERTY_ID id)
    {
        ArgumentNullException.ThrowIfNull(set);
        set.GetPropertyValues(index, id, out var _, out var list);
        return list.GetNames();
    }
}
