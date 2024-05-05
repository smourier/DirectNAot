#nullable enable
namespace DirectN;

[InlineArray(32)]
public partial struct InlineArrayDXVA_VideoSample32
{
    public static int Length => 32;
    
    public DXVA_VideoSample Data;
}
