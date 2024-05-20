#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_11.Length)]
public partial struct InlineArrayChar_11
{
    public const int Length = 11;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
