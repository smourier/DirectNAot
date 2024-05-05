#nullable enable
namespace DirectN;

[InlineArray(255)]
public partial struct InlineArrayChar255
{
    public static int Length => 255;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
