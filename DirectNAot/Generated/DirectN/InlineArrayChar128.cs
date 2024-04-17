namespace DirectN;

[InlineArray(128)]
public partial struct InlineArrayChar128
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
