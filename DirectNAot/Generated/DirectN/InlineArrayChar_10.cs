#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_10.Length)]
public partial struct InlineArrayChar_10
{
    public const int Length = 10;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
