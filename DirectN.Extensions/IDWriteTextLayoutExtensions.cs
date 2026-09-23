namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class IDWriteTextLayoutExtensions
{
    public static string GetFontFamilyName(this IComObject<IDWriteTextLayout> layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetFontFamilyName(layout?.Object!, currentPosition, range);
    public static string GetFontFamilyName(this IDWriteTextLayout layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
    {
        ArgumentNullException.ThrowIfNull(layout);
        if (range == null)
            return call(0);

        return call(range.GetValuePointer());

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

        return call(range.GetValuePointer());

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
        if (OperatingSystem.IsWindowsVersionAtLeast(8, 1) && layout is IDWriteTextLayout2 layout2)
        {
            layout2.GetMetrics(out metrics1).ThrowOnError();
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

        return call(range.GetValuePointer());

        ComObject<IDWriteFontCollection> call(nint ptr)
        {
            layout.GetFontCollection(currentPosition, out var coll, ptr).ThrowOnError();
            return new ComObject<IDWriteFontCollection>(coll);
        }
    }

    public static DWRITE_TEXT_METRICS GetMetrics(this IComObject<IDWriteTextLayout> layout) => GetMetrics(layout?.Object!);
    public static DWRITE_TEXT_METRICS GetMetrics(this IDWriteTextLayout layout)
    {
        ArgumentNullException.ThrowIfNull(layout);
        layout.GetMetrics(out var metrics).ThrowOnError();
        return metrics;
    }

    public static DWRITE_OVERHANG_METRICS GetOverhangMetrics(this IComObject<IDWriteTextLayout> layout) => GetOverhangMetrics(layout?.Object!);
    public static DWRITE_OVERHANG_METRICS GetOverhangMetrics(this IDWriteTextLayout layout)
    {
        ArgumentNullException.ThrowIfNull(layout);
        layout.GetOverhangMetrics(out var metrics).ThrowOnError();
        return metrics;
    }

    public static DWRITE_HIT_TEST_METRICS HitTestTextPosition(this IComObject<IDWriteTextLayout> layout, uint textPosition, bool isTrailingHit, out float pointX, out float pointY) => HitTestTextPosition(layout?.Object!, textPosition, isTrailingHit, out pointX, out pointY);
    public static DWRITE_HIT_TEST_METRICS HitTestTextPosition(this IDWriteTextLayout layout, uint textPosition, bool isTrailingHit, out float pointX, out float pointY)
    {
        ArgumentNullException.ThrowIfNull(layout);
        layout.HitTestTextPosition(textPosition, isTrailingHit, out pointX, out pointY, out var metrics).ThrowOnError();
        return metrics;
    }

    public static DWRITE_HIT_TEST_METRICS HitTestPoint(this IComObject<IDWriteTextLayout> layout, float pointX, float pointY, out bool isTrailingHit, out bool isInside) => HitTestPoint(layout?.Object!, pointX, pointY, out isTrailingHit, out isInside);
    public static DWRITE_HIT_TEST_METRICS HitTestPoint(this IDWriteTextLayout layout, float pointX, float pointY, out bool isTrailingHit, out bool isInside)
    {
        ArgumentNullException.ThrowIfNull(layout);
        layout.HitTestPoint(pointX, pointY, out var trailing, out var inside, out var metrics).ThrowOnError();
        isTrailingHit = trailing;
        isInside = inside;
        return metrics;
    }

    public static IReadOnlyList<DWRITE_LINE_METRICS> GetLineMetrics(this IComObject<IDWriteTextLayout> layout) => GetLineMetrics(layout?.Object!);
    public static IReadOnlyList<DWRITE_LINE_METRICS> GetLineMetrics(this IDWriteTextLayout layout)
    {
        ArgumentNullException.ThrowIfNull(layout);
        layout.GetLineMetrics(0, 0, out var count).ThrowOnErrorExcept(Constants.E_NOT_SUFFICIENT_BUFFER);
        var metrics = new DWRITE_LINE_METRICS[count];
        if (count > 0)
        {
            using var pinned = metrics.Pin();
            layout.GetLineMetrics(pinned.Pointer, count, out _).ThrowOnError();
        }
        return metrics;
    }

    public static IReadOnlyList<DWRITE_CLUSTER_METRICS> GetClusterMetrics(this IComObject<IDWriteTextLayout> layout) => GetClusterMetrics(layout?.Object!);
    public static IReadOnlyList<DWRITE_CLUSTER_METRICS> GetClusterMetrics(this IDWriteTextLayout layout)
    {
        ArgumentNullException.ThrowIfNull(layout);
        layout.GetClusterMetrics(0, 0, out var count).ThrowOnErrorExcept(Constants.E_NOT_SUFFICIENT_BUFFER);
        var metrics = new DWRITE_CLUSTER_METRICS[count];
        if (count > 0)
        {
            using var pinned = metrics.Pin();
            layout.GetClusterMetrics(pinned.Pointer, count, out _).ThrowOnError();
        }
        return metrics;
    }
}
