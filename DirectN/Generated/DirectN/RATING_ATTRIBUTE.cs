#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct RATING_ATTRIBUTE
{
    public uint rating_attribute_id;
    public uint rating_attribute_value;
}
