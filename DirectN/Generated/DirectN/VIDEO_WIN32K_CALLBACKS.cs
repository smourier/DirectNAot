#nullable enable
namespace DirectN;

public partial struct VIDEO_WIN32K_CALLBACKS
{
    public nint PhysDisp;
    public nint Callout;
    public uint bACPI;
    public HANDLE pPhysDeviceObject;
    public uint DualviewFlags;
}
