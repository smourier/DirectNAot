namespace DirectN;

[InlineArray(49)]
public partial struct InlineArrayChar49
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
