#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-play-parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_PLAY_PARMS
{
    public nuint dwCallback;
    public uint dwFrom;
    public uint dwTo;
}
