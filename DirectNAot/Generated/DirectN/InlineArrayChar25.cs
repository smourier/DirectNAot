#nullable enable
namespace DirectN;

[InlineArray(25)]
public partial struct InlineArrayChar25
{
    public static int Length => 25;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
