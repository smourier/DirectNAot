#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/joystickapi/ns-joystickapi-joyinfoex
[StructLayout(LayoutKind.Sequential)]
public partial struct JOYINFOEX
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwXpos;
    public uint dwYpos;
    public uint dwZpos;
    public uint dwRpos;
    public uint dwUpos;
    public uint dwVpos;
    public uint dwButtons;
    public uint dwButtonNumber;
    public uint dwPOV;
    public uint dwReserved1;
    public uint dwReserved2;
}
