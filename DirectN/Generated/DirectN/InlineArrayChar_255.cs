#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_255.Length)]
public partial struct InlineArrayChar_255
{
    public const int Length = 255;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_255>(str, this, Length);
    public static implicit operator InlineArrayChar_255(string? str) { var n = new InlineArrayChar_255(); n.CopyFrom(str); return n; }
}
