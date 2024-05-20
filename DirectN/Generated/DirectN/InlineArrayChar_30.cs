#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_30.Length)]
public partial struct InlineArrayChar_30
{
    public const int Length = 30;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
