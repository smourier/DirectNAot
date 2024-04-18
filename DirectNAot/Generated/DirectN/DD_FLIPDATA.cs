namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_flipdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_FLIPDATA
{
    public nint lpDD;
    public nint lpSurfCurr;
    public nint lpSurfTarg;
    public uint dwFlags;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint Flip;
    public nint lpSurfCurrLeft;
    public nint lpSurfTargLeft;
}
