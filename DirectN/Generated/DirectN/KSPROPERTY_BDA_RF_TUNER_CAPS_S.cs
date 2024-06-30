#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_BDA_RF_TUNER_CAPS_S
{
    public KSP_NODE Property;
    public uint Mode;
    public uint AnalogStandardsSupported;
    public uint DigitalStandardsSupported;
    public uint MinFrequency;
    public uint MaxFrequency;
    public uint SettlingTime;
    public uint AnalogSensingRange;
    public uint DigitalSensingRange;
    public uint MilliSecondsPerMHz;
}
