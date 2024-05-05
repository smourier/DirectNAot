#nullable enable
namespace DirectN;

[InlineArray(36)]
public partial struct InlineArrayChar36
{
    public static int Length => 36;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
