#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VBICAP_PROPERTIES_PROTECTION_S
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public uint Status;
}
