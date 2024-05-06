#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_19.Length)]
public partial struct InlineArrayChar_19
{
    public const int Length = 19;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
