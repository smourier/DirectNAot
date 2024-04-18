namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_flipvportdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_FLIPVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lpSurfCurr;
    public nint lpSurfTarg;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint FlipVideoPort;
}
