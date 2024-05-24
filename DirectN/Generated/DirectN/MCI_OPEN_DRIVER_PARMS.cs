#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_OPEN_DRIVER_PARMS
{
    public uint wDeviceID;
    public PWSTR lpstrParams;
    public uint wCustomCommandTable;
    public uint wType;
}
