#nullable enable
namespace DirectN;

public partial struct PROCESS_LIST
{
    public nint lpLink;
    public uint dwProcessId;
    public uint dwRefCnt;
    public uint dwAlphaDepth;
    public uint dwZDepth;
}
