namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteFactoryExtensions
{
    public static IComObject<IDWriteTextFormat> CreateTextFormat(this IComObject<IDWriteFactory> factory,
        string familyName,
        float size,
        IDWriteFontCollection? fonts = null,
        DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL,
        DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL,
        DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL,
        string? localeName = null) => CreateTextFormat<IDWriteTextFormat>(factory?.Object!, familyName, size, fonts, weight, style, stretch, localeName);

    public static IComObject<T> CreateTextFormat<T>(this IComObject<IDWriteFactory> factory,
        string familyName,
        float size,
        IDWriteFontCollection? fonts = null,
        DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL,
        DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL,
        DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL,
        string? localeName = null) where T : IDWriteTextFormat => CreateTextFormat<T>(factory?.Object!, familyName, size, fonts, weight, style, stretch, localeName);

    public static IComObject<T> CreateTextFormat<T>(this IDWriteFactory factory,
        string familyName,
        float size,
        IDWriteFontCollection? fonts = null,
        DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL,
        DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL,
        DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL,
        string? localeName = null) where T : IDWriteTextFormat
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(familyName);
        localeName ??= string.Empty;
        factory.CreateTextFormat(PWSTR.From(familyName), fonts, weight, style, stretch, size, PWSTR.From(localeName), out var format).ThrowOnError();
        return new ComObject<T>((T)format);
    }

    public static IComObject<IDWriteTextLayout> CreateTextLayout(this IComObject<IDWriteFactory> factory,
        IComObject<IDWriteTextFormat> format,
        string text,
        int textLength = 0,
        float maxWidth = float.MaxValue,
        float maxHeight = float.MaxValue) => CreateTextLayout<IDWriteTextLayout>(factory?.Object!, format?.Object!, text, textLength, maxWidth, maxHeight);

    public static IComObject<T> CreateTextLayout<T>(this IComObject<IDWriteFactory> factory,
        IComObject<IDWriteTextFormat> format,
        string text,
        int textLength = 0,
        float maxWidth = float.MaxValue,
        float maxHeight = float.MaxValue) where T : IDWriteTextLayout => CreateTextLayout<T>(factory?.Object!, format?.Object!, text, textLength, maxWidth, maxHeight);

    public static IComObject<T> CreateTextLayout<T>(this IDWriteFactory factory,
        IDWriteTextFormat format,
        string text,
        int textLength = 0,
        float maxWidth = float.MaxValue,
        float maxHeight = float.MaxValue
        ) where T : IDWriteTextLayout
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(format);
        ArgumentNullException.ThrowIfNull(text);
        textLength = textLength <= 0 ? text.Length : textLength;
        factory.CreateTextLayout(PWSTR.From(text), (uint)textLength, format, maxWidth, maxHeight, out var layout).ThrowOnError();
        return new ComObject<T>((T)layout);
    }

    public static IComObject<IDWriteInlineObject> CreateEllipsisTrimmingSign(this IComObject<IDWriteFactory> factory, IComObject<IDWriteTextFormat> format) =>
        CreateEllipsisTrimmingSign(factory?.Object!, format?.Object!);
    public static IComObject<IDWriteInlineObject> CreateEllipsisTrimmingSign(this IDWriteFactory factory, IDWriteTextFormat format)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(format);
        factory.CreateEllipsisTrimmingSign(format, out var sign).ThrowOnError();
        return new ComObject<IDWriteInlineObject>(sign);
    }

    public static IComObject<IDWriteFontSetBuilder1> CreateFontSetBuilder(this IComObject<IDWriteFactory5> factory) => CreateFontSetBuilder<IDWriteFontSetBuilder1>(factory);
    public static IComObject<T> CreateFontSetBuilder<T>(this IComObject<IDWriteFactory5> factory) where T : IDWriteFontSetBuilder1 => CreateFontSetBuilder<T>(factory?.Object!);
    public static IComObject<T> CreateFontSetBuilder<T>(this IDWriteFactory5 factory) where T : IDWriteFontSetBuilder1
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateFontSetBuilder(out IDWriteFontSetBuilder1 builder).ThrowOnError();
        return new ComObject<T>((T)builder);
    }

    public static IComObject<IDWriteFontFile> CreateFontFileReference(this IComObject<IDWriteFactory5> factory, string filePath, DateTime? lastWriteTime = null) =>
        CreateFontFileReference(factory?.Object!, filePath, lastWriteTime);
    public static IComObject<IDWriteFontFile> CreateFontFileReference(this IDWriteFactory5 factory, string filePath, DateTime? lastWriteTime = null)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(filePath);
        IDWriteFontFile file;
        if (lastWriteTime == null)
        {
            factory.CreateFontFileReference(PWSTR.From(filePath), 0, out file).ThrowOnError();
        }
        else
        {
            var time = lastWriteTime.Value.ToFileTime();
            unsafe
            {
                factory.CreateFontFileReference(PWSTR.From(filePath), (nint)(&time), out file).ThrowOnError();
            }
        }
        return new ComObject<IDWriteFontFile>(file);
    }

    public static IComObject<IDWriteFontFile> CreateCustomFontFileReference(this IComObject<IDWriteFactory5> factory, nint key, uint keySize, IComObject<IDWriteFontFileLoader> loader) =>
        CreateCustomFontFileReference(factory?.Object!, key, keySize, loader?.Object!);
    public static IComObject<IDWriteFontFile> CreateCustomFontFileReference(this IDWriteFactory5 factory, nint key, uint keySize, IDWriteFontFileLoader loader)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(loader);
        factory.CreateCustomFontFileReference(key, keySize, loader, out var file).ThrowOnError();
        return new ComObject<IDWriteFontFile>(file);
    }

    public static IComObject<IDWriteTypography> CreateTypography(this IComObject<IDWriteFactory> factory) => CreateTypography(factory?.Object!);
    public static IComObject<IDWriteTypography> CreateTypography(this IDWriteFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateTypography(out var typography).ThrowOnError();
        return new ComObject<IDWriteTypography>(typography);
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public static IComObject<IDWriteFontSet> GetSystemFontSet(this IComObject<IDWriteFactory3> factory) => GetSystemFontSet<IDWriteFontSet>(factory?.Object!);

    [SupportedOSPlatform("windows10.0.10240")]
    public static IComObject<T> GetSystemFontSet<T>(this IComObject<IDWriteFactory3> factory) where T : IDWriteFontSet => GetSystemFontSet<T>(factory?.Object!);

    [SupportedOSPlatform("windows10.0.10240")]
    public static IComObject<T> GetSystemFontSet<T>(this IDWriteFactory3 factory) where T : IDWriteFontSet
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.GetSystemFontSet(out var set).ThrowOnError();
        return new ComObject<T>(set);
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public static IComObject<IDWriteFontCollection1> CreateFontCollectionFromFontSet(this IComObject<IDWriteFactory5> factory, IComObject<IDWriteFontSet> set)
        => CreateFontCollectionFromFontSet<IDWriteFontCollection1>(factory?.Object!, set?.Object!);

    [SupportedOSPlatform("windows10.0.10240")]
    public static IComObject<T> CreateFontCollectionFromFontSet<T>(this IComObject<IDWriteFactory5> factory, IComObject<IDWriteFontSet> set) where T : IDWriteFontCollection1
        => CreateFontCollectionFromFontSet<T>(factory?.Object!, set?.Object!);

    [SupportedOSPlatform("windows10.0.10240")]
    public static IComObject<T> CreateFontCollectionFromFontSet<T>(this IDWriteFactory5 factory, IDWriteFontSet set) where T : IDWriteFontCollection1
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(set);
        factory.CreateFontCollectionFromFontSet(set, out var coll).ThrowOnError();
        return new ComObject<T>(coll);
    }

    public static void RegisterFontFileLoader(this IComObject<IDWriteFactory5> factory, IComObject<IDWriteFontFileLoader> loader) => RegisterFontFileLoader(factory?.Object!, loader?.Object!);
    public static void RegisterFontFileLoader(this IDWriteFactory5 factory, IDWriteFontFileLoader loader)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(loader);
        factory.RegisterFontFileLoader(loader).ThrowOnError();
    }

    public static void UnregisterFontFileLoader(this IComObject<IDWriteFactory5> factory, IComObject<IDWriteFontFileLoader> loader) => UnregisterFontFileLoader(factory?.Object!, loader?.Object!);
    public static void UnregisterFontFileLoader(this IDWriteFactory5 factory, IDWriteFontFileLoader loader)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(loader);
        factory.UnregisterFontFileLoader(loader).ThrowOnError();
    }

    public static void RegisterFontCollectionLoader(this IComObject<IDWriteFactory5> factory, IComObject<IDWriteFontCollectionLoader> loader) => RegisterFontCollectionLoader(factory?.Object!, loader?.Object!);
    public static void RegisterFontCollectionLoader(this IDWriteFactory5 factory, IDWriteFontCollectionLoader loader)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(loader);
        factory.RegisterFontCollectionLoader(loader).ThrowOnError();
    }

    public static void UnregisterFontCollectionLoader(this IComObject<IDWriteFactory5> factory, IComObject<IDWriteFontCollectionLoader> loader) => UnregisterFontCollectionLoader(factory?.Object!, loader?.Object!);
    public static void UnregisterFontCollectionLoader(this IDWriteFactory5 factory, IDWriteFontCollectionLoader loader)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(loader);
        factory.UnregisterFontCollectionLoader(loader).ThrowOnError();
    }
}
