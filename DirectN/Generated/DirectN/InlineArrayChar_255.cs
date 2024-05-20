#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_255.Length)]
public partial struct InlineArrayChar_255
{
    public const int Length = 255;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
