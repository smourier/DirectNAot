namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct RIFFCHUNK
{
    public uint fcc;
    public uint cb;
}
