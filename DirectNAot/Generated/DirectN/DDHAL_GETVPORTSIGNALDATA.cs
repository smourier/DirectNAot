#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTSIGNALDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwStatus;
    public HRESULT ddRVal;
    public nint GetVideoSignalStatus;
}
