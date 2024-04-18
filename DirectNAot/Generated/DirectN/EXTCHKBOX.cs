namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EXTCHKBOX
{
    public ushort cbSize;
    public ushort Flags;
    public nint pTitle;
    public nint pSeparator;
    public nint pCheckedName;
    public nuint IconID;
    public InlineArrayUInt164 wReserved;
    public InlineArrayUIntPtr2 dwReserved;
}
