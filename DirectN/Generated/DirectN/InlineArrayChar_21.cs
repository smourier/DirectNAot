#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_21.Length)]
public partial struct InlineArrayChar_21
{
    public const int Length = 21;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
