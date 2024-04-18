namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_FLIPVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lpSurfCurr;
    public nint lpSurfTarg;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint FlipVideoPort;
}
