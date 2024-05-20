#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_26.Length)]
public partial struct InlineArrayChar_26
{
    public const int Length = 26;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
