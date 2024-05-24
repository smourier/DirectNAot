#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-wave-set-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_WAVE_SET_PARMS
{
    public nuint dwCallback;
    public uint dwTimeFormat;
    public uint dwAudio;
    public uint wInput;
    public uint wOutput;
    public ushort wFormatTag;
    public ushort wReserved2;
    public ushort nChannels;
    public ushort wReserved3;
    public uint nSamplesPerSec;
    public uint nAvgBytesPerSec;
    public ushort nBlockAlign;
    public ushort wReserved4;
    public ushort wBitsPerSample;
    public ushort wReserved5;
}
