namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYDRIVERDATA
{
    public nint lpDD;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint DestroyDriver;
}
