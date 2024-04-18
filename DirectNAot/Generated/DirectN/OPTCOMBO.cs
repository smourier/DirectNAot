namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OPTCOMBO
{
    public ushort cbSize;
    public byte Flags;
    public ushort cListItem;
    public nint pListItem;
    public int Sel;
    public InlineArrayUInt323 dwReserved;
}
