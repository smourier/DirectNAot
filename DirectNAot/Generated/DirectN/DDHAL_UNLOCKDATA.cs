namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_UNLOCKDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public HRESULT ddRVal;
    public nint Unlock;
}
