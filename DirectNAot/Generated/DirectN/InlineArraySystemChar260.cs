namespace DirectN;

[InlineArray(260)]
public partial struct InlineArraySystemChar260
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
