#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct KSPROPERTY_SERIALHDR
{
    public Guid PropertySet;
    public uint Count;
}
