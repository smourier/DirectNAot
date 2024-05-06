#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_16.Length)]
public partial struct InlineArraySystemChar_16
{
    public const int Length = 16;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
