#nullable enable
namespace DirectN;

[InlineArray(128)]
public partial struct InlineArrayUInt32128
{
    public static int Length => 128;
    
    public uint Data;
}
