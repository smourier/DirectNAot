#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-hardwareinput
public partial struct HARDWAREINPUT
{
    public uint uMsg;
    public ushort wParamL;
    public ushort wParamH;
}
