#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_SERIALHDR
{
    public Guid PropertySet;
    public uint Count;
}
