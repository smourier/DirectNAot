#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_260.Length)]
public partial struct InlineArraySystemChar_260
{
    public const int Length = 260;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_260>(str, this, Length);
    public static implicit operator InlineArraySystemChar_260(string? str) { var n = new InlineArraySystemChar_260(); n.CopyFrom(str); return n; }
}
