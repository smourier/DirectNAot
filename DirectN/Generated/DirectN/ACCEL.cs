#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-accel
public partial struct ACCEL
{
    public ACCEL_VIRT_FLAGS fVirt;
    public ushort key;
    public ushort cmd;
}
