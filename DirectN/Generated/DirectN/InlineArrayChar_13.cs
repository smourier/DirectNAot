#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_13.Length)]
public partial struct InlineArrayChar_13
{
    public const int Length = 13;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
