namespace DirectN;

[InlineArray(255)]
public partial struct InlineArrayChar255
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
