#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-pointer_pen_info
[StructLayout(LayoutKind.Sequential)]
public partial struct POINTER_PEN_INFO
{
    public POINTER_INFO pointerInfo;
    public uint penFlags;
    public uint penMask;
    public uint pressure;
    public uint rotation;
    public int tiltX;
    public int tiltY;
}
