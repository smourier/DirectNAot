#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_25.Length)]
public partial struct InlineArrayChar_25
{
    public const int Length = 25;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_25>(str, this, Length);
    public static implicit operator InlineArrayChar_25(string? str) { var n = new InlineArrayChar_25(); n.CopyFrom(str); return n; }
}
