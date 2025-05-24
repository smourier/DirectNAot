#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-windowplacement
public partial struct WINDOWPLACEMENT
{
    public uint length;
    public WINDOWPLACEMENT_FLAGS flags;
    public uint showCmd;
    public POINT ptMinPosition;
    public POINT ptMaxPosition;
    public RECT rcNormalPosition;
}
