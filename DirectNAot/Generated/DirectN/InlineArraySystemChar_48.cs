#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_48.Length)]
public partial struct InlineArraySystemChar_48
{
    public const int Length = 48;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
