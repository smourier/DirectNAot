namespace DirectN.Extensions;

public static class IDWriteFontSetBuilderExtensions
{
    [SupportedOSPlatform("windows10.0.10240")]
    public static IComObject<IDWriteFontSet> CreateFontSet(this IComObject<IDWriteFontSetBuilder> builder) => CreateFontSet<IDWriteFontSet>(builder);
    public static IComObject<T> CreateFontSet<T>(this IComObject<IDWriteFontSetBuilder> builder) where T : IDWriteFontSet => CreateFontSet<T>(builder?.Object!);
    public static IComObject<T> CreateFontSet<T>(this IDWriteFontSetBuilder builder) where T : IDWriteFontSet
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.CreateFontSet(out var set).ThrowOnError();
        return new ComObject<T>((T)set);
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public static void AddFontSet(this IComObject<IDWriteFontSetBuilder> builder, IComObject<IDWriteFontSet> set) => AddFontSet(builder?.Object!, set?.Object!);
    public static void AddFontSet(this IDWriteFontSetBuilder builder, IDWriteFontSet set)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(set);
        builder.AddFontSet(set).ThrowOnError();
    }

    [SupportedOSPlatform("windows6.1")]
    public static void AddFontFile(this IComObject<IDWriteFontSetBuilder1> builder, IComObject<IDWriteFontFile> file) => AddFontFile(builder?.Object!, file?.Object!);
    public static void AddFontFile(this IDWriteFontSetBuilder1 builder, IDWriteFontFile file)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(file);
        builder.AddFontFile(file).ThrowOnError();
    }

    public static void AddFontFile(this IComObject<IDWriteFontSetBuilder2> builder, string filePath) => AddFontFile(builder?.Object!, filePath);
    public static void AddFontFile(this IDWriteFontSetBuilder2 builder, string filePath)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(filePath);
        builder.AddFontFile(PWSTR.From(filePath)).ThrowOnError();
    }
}
