#nullable enable
namespace DirectN;

[InlineArray(13)]
public partial struct InlineArrayChar13
{
    public static int Length => 13;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
