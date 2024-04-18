namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PROPSHEETUI_INFO_HEADER
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HICON hIcon;
        
        [FieldOffset(0)]
        public nuint IconID;
    }
    
    public ushort cbSize;
    public ushort Flags;
    public nint pTitle;
    public HWND hWndParent;
    public HINSTANCE hInst;
    public _Anonymous_e__Union Anonymous;
}
