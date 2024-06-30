#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_videoportcallbacks
public partial struct DD_VIDEOPORTCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint CanCreateVideoPort;
    public nint CreateVideoPort;
    public nint FlipVideoPort;
    public nint GetVideoPortBandwidth;
    public nint GetVideoPortInputFormats;
    public nint GetVideoPortOutputFormats;
    public nint lpReserved1;
    public nint GetVideoPortField;
    public nint GetVideoPortLine;
    public nint GetVideoPortConnectInfo;
    public nint DestroyVideoPort;
    public nint GetVideoPortFlipStatus;
    public nint UpdateVideoPort;
    public nint WaitForVideoPortSync;
    public nint GetVideoSignalStatus;
    public nint ColorControl;
}
