namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddoverlayfx
[StructLayout(LayoutKind.Sequential)]
public partial struct DDOVERLAYFX
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint dwAlphaDestConst;
        
        [FieldOffset(0)]
        public nint lpDDSAlphaDest;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint dwAlphaSrcConst;
        
        [FieldOffset(0)]
        public nint lpDDSAlphaSrc;
    }
    
    public uint dwSize;
    public uint dwAlphaEdgeBlendBitDepth;
    public uint dwAlphaEdgeBlend;
    public uint dwReserved;
    public uint dwAlphaDestConstBitDepth;
    public _Anonymous1_e__Union Anonymous1;
    public uint dwAlphaSrcConstBitDepth;
    public _Anonymous2_e__Union Anonymous2;
    public DDCOLORKEY dckDestColorkey;
    public DDCOLORKEY dckSrcColorkey;
    public uint dwDDFX;
    public uint dwFlags;
}
