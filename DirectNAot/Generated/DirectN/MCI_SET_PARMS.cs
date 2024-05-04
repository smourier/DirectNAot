#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-set-parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_SET_PARMS
{
    public nuint dwCallback;
    public uint dwTimeFormat;
    public uint dwAudio;
}
