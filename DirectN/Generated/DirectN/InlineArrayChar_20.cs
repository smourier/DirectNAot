#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_20.Length)]
public partial struct InlineArrayChar_20
{
    public const int Length = 20;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
