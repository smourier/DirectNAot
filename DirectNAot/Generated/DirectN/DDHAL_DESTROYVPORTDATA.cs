namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint DestroyVideoPort;
}
