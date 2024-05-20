#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_31.Length)]
public partial struct InlineArrayChar_31
{
    public const int Length = 31;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
