#nullable enable
namespace DirectN;

[InlineArray(256)]
public partial struct InlineArrayRGBQUAD256
{
    public static int Length => 256;
    
    public RGBQUAD Data;
}
