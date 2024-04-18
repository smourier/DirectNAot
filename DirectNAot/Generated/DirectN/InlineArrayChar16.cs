namespace DirectN;

[InlineArray(16)]
public partial struct InlineArrayChar16
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
