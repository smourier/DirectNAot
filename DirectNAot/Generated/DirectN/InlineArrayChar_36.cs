#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_36.Length)]
public partial struct InlineArrayChar_36
{
    public const int Length = 36;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
