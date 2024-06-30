#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_TUNER_SCAN_CAPS_S
{
    public KSIDENTIFIER Property;
    public BOOL fSupportsHardwareAssistedScanning;
    public uint SupportedBroadcastStandards;
    public nint GUIDBucket;
    public uint lengthofBucket;
}
