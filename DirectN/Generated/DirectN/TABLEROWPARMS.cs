#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-tablerowparms
[StructLayout(LayoutKind.Sequential)]
public partial struct TABLEROWPARMS
{
    public byte cbRow;
    public byte cbCell;
    public byte cCell;
    public byte cRow;
    public int dxCellMargin;
    public int dxIndent;
    public int dyHeight;
    public uint _bitfield;
    public int cpStartRow;
    public byte bTableLevel;
    public byte iCell;
}
