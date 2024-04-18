namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DDVIDEOPORTCALLBACKS
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
