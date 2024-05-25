#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_27.Length)]
public partial struct InlineArrayChar_27
{
    public const int Length = 27;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_27>(str, this, Length);
    public static implicit operator InlineArrayChar_27(string? str) { var n = new InlineArrayChar_27(); n.CopyFrom(str); return n; }
}
