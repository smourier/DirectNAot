#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_WAVE
{
    public uint ulFirstExtCkIdx;
    public uint ulCopyrightIdx;
    public uint ulWaveDataIdx;
    public WAVEFORMATEX WaveformatEx;
}
