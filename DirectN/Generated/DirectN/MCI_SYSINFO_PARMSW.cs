#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_SYSINFO_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrReturn;
    public uint dwRetSize;
    public uint dwNumber;
    public uint wDeviceType;
}
