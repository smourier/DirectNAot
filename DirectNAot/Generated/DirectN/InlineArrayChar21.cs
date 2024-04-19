namespace DirectN;

[InlineArray(21)]
public partial struct InlineArrayChar21
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
