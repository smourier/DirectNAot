#nullable enable
namespace DirectN;

[InlineArray(17)]
public partial struct InlineArrayChar17
{
    public static int Length => 17;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
