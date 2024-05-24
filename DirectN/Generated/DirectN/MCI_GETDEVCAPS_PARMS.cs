#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-getdevcaps-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_GETDEVCAPS_PARMS
{
    public nuint dwCallback;
    public uint dwReturn;
    public uint dwItem;
}
