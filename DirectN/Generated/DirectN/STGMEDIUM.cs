#nullable enable
namespace DirectN;

public partial struct STGMEDIUM
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _u_e__Union
    {
        [FieldOffset(0)]
        public HBITMAP hBitmap;
        
        [FieldOffset(0)]
        public nint hMetaFilePict;
        
        [FieldOffset(0)]
        public HENHMETAFILE hEnhMetaFile;
        
        [FieldOffset(0)]
        public HGLOBAL hGlobal;
        
        [FieldOffset(0)]
        public PWSTR lpszFileName;
        
        [FieldOffset(0)]
        public nint pstm;
        
        [FieldOffset(0)]
        public nint pstg;
    }
    
    public uint tymed;
    public _u_e__Union u;
    public nint pUnkForRelease;
}
