#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TUNER_NETWORKTYPE_SCAN_CAPS_S
{
    public KSIDENTIFIER Property;
    public Guid NetworkType;
    public uint BufferSize;
    public nint NetworkTunerCapabilities;
}
