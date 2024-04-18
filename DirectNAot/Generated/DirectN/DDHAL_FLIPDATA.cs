namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_FLIPDATA
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
