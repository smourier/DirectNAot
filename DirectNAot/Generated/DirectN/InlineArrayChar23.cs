namespace DirectN;

[InlineArray(23)]
public partial struct InlineArrayChar23
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
