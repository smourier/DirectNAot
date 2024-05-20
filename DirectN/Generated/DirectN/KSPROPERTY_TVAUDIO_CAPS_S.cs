#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TVAUDIO_CAPS_S
{
    public KSIDENTIFIER Property;
    public uint Capabilities;
    public KSIDENTIFIER InputMedium;
    public KSIDENTIFIER OutputMedium;
}
