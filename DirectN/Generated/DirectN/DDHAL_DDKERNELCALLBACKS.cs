#nullable enable
namespace DirectN;

public partial struct DDHAL_DDKERNELCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint SyncSurfaceData;
    public nint SyncVideoPortData;
}
