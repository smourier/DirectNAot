#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_48.Length)]
public partial struct InlineArraySystemChar_48
{
    public const int Length = 48;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_48>(str, this, Length);
    public static implicit operator InlineArraySystemChar_48(string? str) { var n = new InlineArraySystemChar_48(); n.CopyFrom(str); return n; }
}
