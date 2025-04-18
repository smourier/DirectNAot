#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dresourcestats
public partial struct D3DRESOURCESTATS
{
    public BOOL bThrashing;
    public uint ApproxBytesDownloaded;
    public uint NumEvicts;
    public uint NumVidCreates;
    public uint LastPri;
    public uint NumUsed;
    public uint NumUsedInVidMem;
    public uint WorkingSet;
    public uint WorkingSetBytes;
    public uint TotalManaged;
    public uint TotalBytes;
}
