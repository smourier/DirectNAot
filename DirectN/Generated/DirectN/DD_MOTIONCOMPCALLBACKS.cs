#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_motioncompcallbacks
public partial struct DD_MOTIONCOMPCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint GetMoCompGuids;
    public nint GetMoCompFormats;
    public nint CreateMoComp;
    public nint GetMoCompBuffInfo;
    public nint GetInternalMoCompInfo;
    public nint BeginMoCompFrame;
    public nint EndMoCompFrame;
    public nint RenderMoComp;
    public nint QueryMoCompStatus;
    public nint DestroyMoComp;
}
