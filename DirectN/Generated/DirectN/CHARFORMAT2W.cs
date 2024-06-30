#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-charformat2w
public partial struct CHARFORMAT2W
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint dwReserved;
        
        [FieldOffset(0)]
        public uint dwCookie;
    }
    
    public CHARFORMATW Base;
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
