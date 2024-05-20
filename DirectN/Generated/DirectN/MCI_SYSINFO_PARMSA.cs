#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_SYSINFO_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrReturn;
    public uint dwRetSize;
    public uint dwNumber;
    public uint wDeviceType;
}
