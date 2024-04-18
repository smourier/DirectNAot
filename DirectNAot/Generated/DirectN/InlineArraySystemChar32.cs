namespace DirectN;

[InlineArray(32)]
public partial struct InlineArraySystemChar32
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
