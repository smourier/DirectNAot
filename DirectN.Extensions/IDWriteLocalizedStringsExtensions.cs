namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteLocalizedStringsExtensions
{
    public static IReadOnlyList<DWriteLocalizedString> GetNames(this IDWriteLocalizedStrings strings)
    {
        ArgumentNullException.ThrowIfNull(strings);
        var list = new List<DWriteLocalizedString>((int)strings.GetCount());
        for (var i = 0; i < list.Capacity; i++)
        {
            var name = new DWriteLocalizedString();
            strings.GetLocaleNameLength((uint)i, out var len).ThrowOnError();
            using var p1 = new AllocPwstr((len + 1) * 2);
            strings.GetLocaleName((uint)i, p1, p1.SizeInChars);
            name.LocaleName = p1.ToString();

            strings.GetStringLength((uint)i, out len).ThrowOnError();
            using var p2 = new AllocPwstr((len + 1) * 2);
            strings.GetString((uint)i, p2, p2.SizeInChars);
            name.String = p2.ToString();

            list.Add(name);
        }
        return list;
    }
}
