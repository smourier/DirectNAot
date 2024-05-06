#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_18.Length)]
public partial struct InlineArrayChar_18
{
    public const int Length = 18;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
