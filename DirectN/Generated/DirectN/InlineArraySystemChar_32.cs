#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_32.Length)]
public partial struct InlineArraySystemChar_32
{
    public const int Length = 32;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
