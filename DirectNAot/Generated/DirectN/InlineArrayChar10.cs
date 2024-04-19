namespace DirectN;

[InlineArray(10)]
public partial struct InlineArrayChar10
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
