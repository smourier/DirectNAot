#nullable enable
namespace DirectN;

[InlineArray(48)]
public partial struct InlineArraySystemChar48
{
    public static int Length => 48;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
