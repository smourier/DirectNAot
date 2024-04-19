namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETMOCOMPGUIDSDATA
{
    public nint lpDD;
    public uint dwNumGuids;
    public nint lpGuids;
    public HRESULT ddRVal;
    public nint GetMoCompGuids;
}
