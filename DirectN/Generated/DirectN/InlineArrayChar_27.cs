#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_27.Length)]
public partial struct InlineArrayChar_27
{
    public const int Length = 27;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
