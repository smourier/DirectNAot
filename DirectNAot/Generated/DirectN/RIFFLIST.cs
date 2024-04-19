namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct RIFFLIST
{
    public uint fcc;
    public uint cb;
    public uint fccListType;
}
