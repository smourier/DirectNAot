namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYMOCOMPDATA
{
    public nint lpDD;
    public nint lpMoComp;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint DestroyMoComp;
}
