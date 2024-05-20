namespace DirectN;

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

        var hr = duplication.GetFrameDirtyRects(0, IntPtr.Zero, out var size);
        if (size == 0)
        {
            hr.ThrowOnError(); // won't throw if no error
            return Array.Empty<RECT>();
        }

        var rects = new List<RECT>();
        using (var mem = new ComMemory(size))
        {
            var rectSize = Marshal.SizeOf<RECT>();
            var curSize = 0;
            duplication.GetFrameDirtyRects(size, mem.Pointer, out size).ThrowOnError();
            do
            {
                rects.Add(Marshal.PtrToStructure<RECT>(mem.Pointer + curSize));
                curSize += rectSize;
            }
            while (curSize < size);
        }
        return rects.ToArray();
    }
}
