#nullable enable
namespace DirectN;

[InlineArray(256)]
public partial struct InlineArrayUInt16256
{
    public static int Length => 256;
    
    public ushort Data;
}
