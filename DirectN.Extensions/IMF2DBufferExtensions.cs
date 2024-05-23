namespace DirectN;

[SupportedOSPlatform("windows6.0.6000")]
public static class IMF2DBufferExtensions
{
    public static uint GetContiguousLength(this IComObject<IMF2DBuffer> obj) => GetContiguousLength(obj?.Object!);
    public static uint GetContiguousLength(this IMF2DBuffer obj)
    {
        ArgumentNullException.ThrowIfNull(obj);
        obj.GetContiguousLength(out var length).ThrowOnError();
        return length;
    }
}
