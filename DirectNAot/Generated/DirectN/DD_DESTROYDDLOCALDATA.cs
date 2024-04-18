namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DESTROYDDLOCALDATA
{
    public uint dwFlags;
    public nint pDDLcl;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
}
