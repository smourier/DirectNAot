#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-iconinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct ICONINFO
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fIcon;
    public uint xHotspot;
    public uint yHotspot;
    public HBITMAP hbmMask;
    public HBITMAP hbmColor;
}
