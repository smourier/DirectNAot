namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-paintstruct
[StructLayout(LayoutKind.Sequential)]
public partial struct PAINTSTRUCT
{
    public HDC hdc;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fErase;
    public FoundationRECT rcPaint;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fRestore;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fIncUpdate;
    public InlineArrayByte32 rgbReserved;
}
