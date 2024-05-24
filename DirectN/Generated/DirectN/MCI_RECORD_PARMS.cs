#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-record-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_RECORD_PARMS
{
    public nuint dwCallback;
    public uint dwFrom;
    public uint dwTo;
}
