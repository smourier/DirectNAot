#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_25.Length)]
public partial struct InlineArrayChar_25
{
    public const int Length = 25;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
