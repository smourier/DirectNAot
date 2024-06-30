#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-paraformat
public partial struct PARAFORMAT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public ushort wReserved;
        
        [FieldOffset(0)]
        public ushort wEffects;
    }
    
    public uint cbSize;
    public PARAFORMAT_MASK dwMask;
    public PARAFORMAT_NUMBERING wNumbering;
    public _Anonymous_e__Union Anonymous;
    public int dxStartIndent;
    public int dxRightIndent;
    public int dxOffset;
    public PARAFORMAT_ALIGNMENT wAlignment;
    public short cTabCount;
    public InlineArrayUInt32_32 rgxTabs;
}
