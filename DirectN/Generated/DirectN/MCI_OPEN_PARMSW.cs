#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_OPEN_PARMSW
{
    public nuint dwCallback;
    public uint wDeviceID;
    public PWSTR lpstrDeviceType;
    public PWSTR lpstrElementName;
    public PWSTR lpstrAlias;
}
