#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_24.Length)]
public partial struct InlineArrayChar_24
{
    public const int Length = 24;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
