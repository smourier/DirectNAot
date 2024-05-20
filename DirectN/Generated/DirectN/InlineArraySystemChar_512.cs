#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_512.Length)]
public partial struct InlineArraySystemChar_512
{
    public const int Length = 512;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
