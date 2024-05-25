#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct CARET_INFO
{
    [FieldOffset(0)]
    public HBITMAP hbitmap;
    
    [FieldOffset(0)]
    public CARET_FLAGS caretFlags;
}
