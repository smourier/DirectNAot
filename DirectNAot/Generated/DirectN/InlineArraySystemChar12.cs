#nullable enable
namespace DirectN;

[InlineArray(12)]
public partial struct InlineArraySystemChar12
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
