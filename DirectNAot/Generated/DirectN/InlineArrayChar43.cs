namespace DirectN;

[InlineArray(43)]
public partial struct InlineArrayChar43
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
