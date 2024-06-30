#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-charformat2a
public partial struct CHARFORMAT2A
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint dwReserved;
        
        [FieldOffset(0)]
        public uint dwCookie;
    }
    
    public CHARFORMATA Base;
    public ushort wWeight;
    public short sSpacing;
    public COLORREF crBackColor;
    public uint lcid;
    public _Anonymous_e__Union Anonymous;
    public short sStyle;
    public ushort wKerning;
    public byte bUnderlineType;
    public byte bAnimation;
    public byte bRevAuthor;
    public byte bUnderlineColor;
}
