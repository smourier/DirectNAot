#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct RIFFLIST
{
    public uint fcc;
    public uint cb;
    public uint fccListType;
}
