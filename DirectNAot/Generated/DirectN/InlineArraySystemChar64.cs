#nullable enable
namespace DirectN;

[InlineArray(64)]
public partial struct InlineArraySystemChar64
{
    public static int Length => 64;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
