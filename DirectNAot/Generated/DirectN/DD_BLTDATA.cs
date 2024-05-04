namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_bltdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_BLTDATA
{
    public nint lpDD;
    public nint lpDDDestSurface;
    public RECTL rDest;
    public nint lpDDSrcSurface;
    public RECTL rSrc;
    public uint dwFlags;
    public uint dwROPFlags;
    public DDBLTFX bltFX;
    public HRESULT ddRVal;
    public nint Blt;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsClipped;
    public RECTL rOrigDest;
    public RECTL rOrigSrc;
    public uint dwRectCnt;
    public nint prDestRects;
    public uint dwAFlags;
    public DDARGB ddargbScaleFactors;
}
