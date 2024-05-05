#nullable enable
namespace DirectN;

[InlineArray(256)]
public partial struct InlineArraySystemChar256
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
