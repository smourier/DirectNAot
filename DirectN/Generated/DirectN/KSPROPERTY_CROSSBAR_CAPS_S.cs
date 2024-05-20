#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_CROSSBAR_CAPS_S
{
    public KSIDENTIFIER Property;
    public uint NumberOfInputs;
    public uint NumberOfOutputs;
}
