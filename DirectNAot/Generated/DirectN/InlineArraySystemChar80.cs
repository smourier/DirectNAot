#nullable enable
namespace DirectN;

[InlineArray(80)]
public partial struct InlineArraySystemChar80
{
    public static int Length => 80;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
