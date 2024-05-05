#nullable enable
namespace DirectN;

[InlineArray(16)]
public partial struct InlineArraySystemChar16
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
