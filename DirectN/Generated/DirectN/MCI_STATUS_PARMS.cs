#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-status-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_STATUS_PARMS
{
    public nuint dwCallback;
    public nuint dwReturn;
    public uint dwItem;
    public uint dwTrack;
}
