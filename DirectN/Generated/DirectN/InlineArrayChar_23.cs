#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_23.Length)]
public partial struct InlineArrayChar_23
{
    public const int Length = 23;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
