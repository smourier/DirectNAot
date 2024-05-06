#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_17.Length)]
public partial struct InlineArrayChar_17
{
    public const int Length = 17;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
