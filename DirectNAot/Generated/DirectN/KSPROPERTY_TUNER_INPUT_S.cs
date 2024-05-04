#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TUNER_INPUT_S
{
    public KSIDENTIFIER Property;
    public uint InputIndex;
}
