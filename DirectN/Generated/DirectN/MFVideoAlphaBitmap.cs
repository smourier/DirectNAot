#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr9/ns-evr9-mfvideoalphabitmap
[StructLayout(LayoutKind.Sequential)]
public partial struct MFVideoAlphaBitmap
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _bitmap_e__Union
    {
        [FieldOffset(0)]
        public HDC hdc;
        
        [FieldOffset(0)]
        public nint pDDS;
    }
    
    [MarshalAs(UnmanagedType.U4)]
    public bool GetBitmapFromDC;
    public _bitmap_e__Union bitmap;
    public MFVideoAlphaBitmapParams @params;
}
