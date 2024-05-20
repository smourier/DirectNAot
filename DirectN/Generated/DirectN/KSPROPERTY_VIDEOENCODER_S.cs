#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEOENCODER_S
{
    public KSIDENTIFIER Property;
    public int Value;
    public uint Flags;
    public uint Capabilities;
}
