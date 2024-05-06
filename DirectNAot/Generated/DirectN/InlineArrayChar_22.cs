#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_22.Length)]
public partial struct InlineArrayChar_22
{
    public const int Length = 22;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
