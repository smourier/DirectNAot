namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteTextLayoutExtensions
{
    public static string GetFontFamilyName(this IComObject<IDWriteTextLayout> layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetFontFamilyName(layout?.Object!, currentPosition, range);
    public static string GetFontFamilyName(this IDWriteTextLayout layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
    {
        ArgumentNullException.ThrowIfNull(layout);
        if (range == null)
            return call(0);

        return call(range.CopyToPointer());

        string call(nint ptr)
        {
            layout.GetFontFamilyNameLength(currentPosition, out var len, ptr).ThrowOnError();
            using var p = new AllocPwstr((len + 1) * 2);
            layout.GetFontFamilyName(currentPosition, p, p.SizeInChars, ptr).ThrowOnError();
            return p.ToString() ?? string.Empty;
        }
    }

    public static string GetLocaleName(this IComObject<IDWriteTextLayout> layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetLocaleName(layout?.Object!, currentPosition, range);
    public static string GetLocaleName(this IDWriteTextLayout layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
    {
        ArgumentNullException.ThrowIfNull(layout);
        if (range == null)
            return call(0);

        return call(range.CopyToPointer());

        string call(nint ptr)
        {
            layout.GetLocaleNameLength(currentPosition, out var len, ptr).ThrowOnError();
            using var p = new AllocPwstr((len + 1) * 2);
            layout.GetLocaleName(currentPosition, p, p.SizeInChars, ptr).ThrowOnError();
            return p.ToString() ?? string.Empty;
        }
    }

    public static DWRITE_TEXT_METRICS1 GetMetrics1(this IComObject<IDWriteTextLayout> layout) => GetMetrics1(layout?.Object!);
    public static DWRITE_TEXT_METRICS1 GetMetrics1(this IDWriteTextLayout layout)
    {
        ArgumentNullException.ThrowIfNull(layout);
        DWRITE_TEXT_METRICS1 metrics1;
        if (layout is IDWriteTextLayout2 layout2)
        {
#pragma warning disable CA1416 // Validate platform compatibility
            layout2.GetMetrics(out metrics1).ThrowOnError();
#pragma warning restore CA1416 // Validate platform compatibility
        }
        else
        {
            layout.GetMetrics(out var metrics).ThrowOnError();
            metrics1.Base.height = metrics.height;
            metrics1.heightIncludingTrailingWhitespace = metrics.height;
            metrics1.Base.layoutHeight = metrics.layoutHeight;
            metrics1.Base.layoutWidth = metrics.layoutWidth;
            metrics1.Base.left = metrics.left;
            metrics1.Base.lineCount = metrics.lineCount;
            metrics1.Base.maxBidiReorderingDepth = metrics.maxBidiReorderingDepth;
            metrics1.Base.top = metrics.top;
            metrics1.Base.width = metrics.width;
            metrics1.Base.widthIncludingTrailingWhitespace = metrics.widthIncludingTrailingWhitespace;
        }

        // sometimes, there's a bug where widthIncludingTrailingWhitespace is 0 while width is not...
        if (metrics1.Base.widthIncludingTrailingWhitespace < metrics1.Base.width)
        {
            metrics1.Base.widthIncludingTrailingWhitespace = metrics1.Base.width;
        }

        if (metrics1.heightIncludingTrailingWhitespace < metrics1.Base.height)
        {
            metrics1.heightIncludingTrailingWhitespace = metrics1.Base.height;
        }
        return metrics1;
    }

    public static IComObject<IDWriteFontCollection> GetFontCollection(this IComObject<IDWriteTextLayout> layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetFontCollection(layout?.Object!, currentPosition, range);
    public static IComObject<IDWriteFontCollection> GetFontCollection(this IDWriteTextLayout layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
    {
        ArgumentNullException.ThrowIfNull(layout);
        if (range == null)
            return call(0);

        return call(range.CopyToPointer());

        ComObject<IDWriteFontCollection> call(nint ptr)
        {
            layout.GetFontCollection(currentPosition, out var coll, ptr).ThrowOnError();
            return new ComObject<IDWriteFontCollection>(coll);
        }
    }
}
