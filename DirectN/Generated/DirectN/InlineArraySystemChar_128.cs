#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_128.Length)]
public partial struct InlineArraySystemChar_128
{
    public const int Length = 128;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
