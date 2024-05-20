#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_33.Length)]
public partial struct InlineArrayChar_33
{
    public const int Length = 33;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
