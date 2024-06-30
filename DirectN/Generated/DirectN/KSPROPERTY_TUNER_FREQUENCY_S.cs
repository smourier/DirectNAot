#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_TUNER_FREQUENCY_S
{
    public KSIDENTIFIER Property;
    public uint Frequency;
    public uint LastFrequency;
    public uint TuningFlags;
    public uint VideoSubChannel;
    public uint AudioSubChannel;
    public uint Channel;
    public uint Country;
}
