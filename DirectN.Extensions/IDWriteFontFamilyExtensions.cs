namespace DirectN;

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
}
