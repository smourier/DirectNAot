#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/joystickapi/ns-joystickapi-joyinfo
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct JOYINFO
{
    public uint wXpos;
    public uint wYpos;
    public uint wZpos;
    public uint wButtons;
}
