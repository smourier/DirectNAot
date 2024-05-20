#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportconnectdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETVPORTCONNECTDATA
{
    public nint lpDD;
    public uint dwPortId;
    public nint lpConnect;
    public uint dwNumEntries;
    public HRESULT ddRVal;
    public nint GetVideoPortConnectInfo;
}
