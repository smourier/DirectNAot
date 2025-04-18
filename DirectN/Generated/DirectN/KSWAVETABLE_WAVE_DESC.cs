#nullable enable
namespace DirectN;

public partial struct KSWAVETABLE_WAVE_DESC
{
    public KSIDENTIFIER Identifier;
    public uint Size;
    public BOOL Looped;
    public uint LoopPoint;
    public BOOL InROM;
    public KSDATAFORMAT Format;
}
