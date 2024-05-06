#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_12.Length)]
public partial struct InlineArraySystemChar_12
{
    public const int Length = 12;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
