namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_FLIPVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lpSurfCurr;
    public nint lpSurfTarg;
    public HRESULT ddRVal;
    public nint FlipVideoPort;
}
