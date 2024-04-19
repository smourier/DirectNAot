namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHDETW_VIDEOPROCESSBLTHD
{
    public ulong pObject;
    public ulong pOutputSurface;
    public FoundationRECT TargetRect;
    public D3DFORMAT OutputFormat;
    public uint ColorSpace;
    public uint OutputFrame;
    public uint StreamCount;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Enter;
}
