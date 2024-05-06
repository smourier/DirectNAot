#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_15.Length)]
public partial struct InlineArrayChar_15
{
    public const int Length = 15;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
