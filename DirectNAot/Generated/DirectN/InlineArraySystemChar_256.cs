#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_256.Length)]
public partial struct InlineArraySystemChar_256
{
    public const int Length = 256;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
