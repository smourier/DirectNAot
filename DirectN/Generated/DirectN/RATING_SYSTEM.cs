#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct RATING_SYSTEM
{
    public Guid rating_system_id;
    public byte _bitfield;
    public InlineArrayByte_3 country_code;
    public uint rating_attribute_count;
    public nint lpratingattrib;
}
