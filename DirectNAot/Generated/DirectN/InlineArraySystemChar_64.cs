#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_64.Length)]
public partial struct InlineArraySystemChar_64
{
    public const int Length = 64;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
