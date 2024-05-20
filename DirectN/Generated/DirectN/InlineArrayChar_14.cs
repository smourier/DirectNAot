#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_14.Length)]
public partial struct InlineArrayChar_14
{
    public const int Length = 14;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
