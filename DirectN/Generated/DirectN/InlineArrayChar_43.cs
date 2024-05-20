#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_43.Length)]
public partial struct InlineArrayChar_43
{
    public const int Length = 43;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
