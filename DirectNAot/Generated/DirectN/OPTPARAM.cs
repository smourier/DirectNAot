namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OPTPARAM
{
    public ushort cbSize;
    public byte Flags;
    public byte Style;
    public nint pData;
    public nuint IconID;
    public LPARAM lParam;
    public InlineArrayUIntPtr2 dwReserved;
}
