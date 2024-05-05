#nullable enable
namespace DirectN;

[InlineArray(31)]
public partial struct InlineArrayChar31
{
    public static int Length => 31;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
