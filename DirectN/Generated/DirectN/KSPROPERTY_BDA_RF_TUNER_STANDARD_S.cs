#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_BDA_RF_TUNER_STANDARD_S
{
    public KSP_NODE Property;
    public BDA_SignalType SignalType;
    public uint SignalStandard;
}
