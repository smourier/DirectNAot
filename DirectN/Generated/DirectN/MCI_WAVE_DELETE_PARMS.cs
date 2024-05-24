#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-wave-delete-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_WAVE_DELETE_PARMS
{
    public nuint dwCallback;
    public uint dwFrom;
    public uint dwTo;
}
