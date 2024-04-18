namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct USERDATA
{
    public uint dwSize;
    public nuint dwItemID;
    public PSTR pKeyWordName;
    public InlineArrayUInt328 dwReserved;
}
