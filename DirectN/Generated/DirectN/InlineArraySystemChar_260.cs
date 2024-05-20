#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_260.Length)]
public partial struct InlineArraySystemChar_260
{
    public const int Length = 260;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
