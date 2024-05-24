#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_OVLY_OPEN_PARMSA
{
    public nuint dwCallback;
    public uint wDeviceID;
    public PSTR lpstrDeviceType;
    public PSTR lpstrElementName;
    public PSTR lpstrAlias;
    public uint dwStyle;
    public HWND hWndParent;
}
