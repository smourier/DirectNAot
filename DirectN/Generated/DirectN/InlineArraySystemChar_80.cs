#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_80.Length)]
public partial struct InlineArraySystemChar_80
{
    public const int Length = 80;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_80>(str, this, Length);
    public static implicit operator InlineArraySystemChar_80(string? str) { var n = new InlineArraySystemChar_80(); n.CopyFrom(str); return n; }
}
