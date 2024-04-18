namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SETOVERLAYPOSITIONDATA
{
    public nint lpDD;
    public nint lpDDSrcSurface;
    public nint lpDDDestSurface;
    public int lXPos;
    public int lYPos;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint SetOverlayPosition;
}
