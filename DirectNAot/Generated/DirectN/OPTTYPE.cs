namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OPTTYPE
{
    public ushort cbSize;
    public byte Type;
    public byte Flags;
    public ushort Count;
    public ushort BegCtrlID;
    public nint pOptParam;
    public ushort Style;
    public InlineArrayUInt163 wReserved;
    public InlineArrayUIntPtr3 dwReserved;
}
