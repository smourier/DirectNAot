namespace DirectN;

[InlineArray(80)]
public partial struct InlineArraySystemChar80
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
