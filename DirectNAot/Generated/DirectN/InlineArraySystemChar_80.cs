#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_80.Length)]
public partial struct InlineArraySystemChar_80
{
    public const int Length = 80;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
