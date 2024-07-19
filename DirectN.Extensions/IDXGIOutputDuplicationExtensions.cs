namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class IDXGIOutputDuplicationExtensions
{
    public static DXGI_OUTDUPL_DESC GetDesc(this IComObject<IDXGIOutputDuplication> output) => GetDesc(output?.Object!);
    public static DXGI_OUTDUPL_DESC GetDesc(this IDXGIOutputDuplication duplication)
    {
        ArgumentNullException.ThrowIfNull(duplication);
        duplication.GetDesc(out var desc);
        return desc;
    }

    public static RECT[] GetFrameDirtyRects(this IComObject<IDXGIOutputDuplication> output) => GetFrameDirtyRects(output?.Object!);
    public static RECT[] GetFrameDirtyRects(this IDXGIOutputDuplication duplication)
    {
        ArgumentNullException.ThrowIfNull(duplication);
        var hr = duplication.GetFrameDirtyRects(0, 0, out var size);
        if (size == 0)
        {
            hr.ThrowOnError(); // won't throw if no error
            return [];
        }

        unsafe
        {
            var elementSize = sizeof(RECT);
            var rects = new RECT[size / elementSize];
            duplication.GetFrameDirtyRects(size, rects.AsPointer(), out _).ThrowOnError();
            return rects;
        }
    }
}
