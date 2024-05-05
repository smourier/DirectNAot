#nullable enable
namespace DirectN;

[InlineArray(260)]
public partial struct InlineArraySystemChar260
{
    public static int Length => 260;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
