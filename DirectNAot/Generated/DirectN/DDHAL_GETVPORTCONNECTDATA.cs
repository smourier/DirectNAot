namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTCONNECTDATA
{
    public nint lpDD;
    public uint dwPortId;
    public nint lpConnect;
    public uint dwNumEntries;
    public HRESULT ddRVal;
    public nint GetVideoPortConnectInfo;
}
