#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_1.Length)]
public partial struct InlineArraySystemChar_1
{
    public const int Length = 1;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
