namespace DirectN;

[InlineArray(17)]
public partial struct InlineArrayChar17
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
