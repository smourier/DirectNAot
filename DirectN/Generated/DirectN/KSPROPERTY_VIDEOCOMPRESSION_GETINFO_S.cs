#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_VIDEOCOMPRESSION_GETINFO_S
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public int DefaultKeyFrameRate;
    public int DefaultPFrameRate;
    public int DefaultQuality;
    public int NumberOfQualitySettings;
    public int Capabilities;
}
