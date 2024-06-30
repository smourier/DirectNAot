#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-tablecellparms
public partial struct TABLECELLPARMS
{
    public int dxWidth;
    public ushort _bitfield;
    public ushort wShading;
    public short dxBrdrLeft;
    public short dyBrdrTop;
    public short dxBrdrRight;
    public short dyBrdrBottom;
    public COLORREF crBrdrLeft;
    public COLORREF crBrdrTop;
    public COLORREF crBrdrRight;
    public COLORREF crBrdrBottom;
    public COLORREF crBackPat;
    public COLORREF crForePat;
}
