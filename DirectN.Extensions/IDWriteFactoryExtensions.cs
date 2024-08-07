﻿namespace DirectN.Extensions;

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

    public static IComObject<IDWriteInlineObject> CreateEllipsisTrimmingSign(this IComObject<IDWriteFactory> factory, IComObject<IDWriteTextFormat> format) => CreateEllipsisTrimmingSign(factory?.Object!, format?.Object!);
    public static IComObject<IDWriteInlineObject> CreateEllipsisTrimmingSign(this IDWriteFactory factory, IDWriteTextFormat format)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(format);
        factory.CreateEllipsisTrimmingSign(format, out var sign).ThrowOnError();
        return new ComObject<IDWriteInlineObject>(sign);
    }

    public static IComObject<IDWriteFontSetBuilder1>? CreateFontSetBuilder(this IComObject<IDWriteFactory5> factory) => CreateFontSetBuilder<IDWriteFontSetBuilder1>(factory);
    public static IComObject<T>? CreateFontSetBuilder<T>(this IComObject<IDWriteFactory5> factory) where T : IDWriteFontSetBuilder1 => CreateFontSetBuilder<T>(factory?.Object!);
    public static IComObject<T>? CreateFontSetBuilder<T>(this IDWriteFactory5 factory) where T : IDWriteFontSetBuilder1
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateFontSetBuilder(out IDWriteFontSetBuilder1 builder);
        if (builder == null)
            return null;

        return new ComObject<T>((T)builder);
    }

    public static IComObject<IDWriteTypography> CreateTypography(this IComObject<IDWriteFactory> factory) => CreateTypography(factory?.Object!);
    public static IComObject<IDWriteTypography> CreateTypography(this IDWriteFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.CreateTypography(out var typography).ThrowOnError();
        return new ComObject<IDWriteTypography>(typography);
    }
}
