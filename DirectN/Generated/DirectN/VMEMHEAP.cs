#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmemmgr/ns-dmemmgr-vmemheap
public partial struct VMEMHEAP
{
    public uint dwFlags;
    public uint stride;
    public nint freeList;
    public nint allocList;
    public uint dwTotalSize;
    public nuint fpGARTLin;
    public nuint fpGARTDev;
    public uint dwCommitedSize;
    public uint dwCoalesceCount;
    public HEAPALIGNMENT Alignment;
    public DDSCAPSEX ddsCapsEx;
    public DDSCAPSEX ddsCapsExAlt;
    public long liPhysAGPBase;
    public HANDLE hdevAGP;
    public nint pvPhysRsrv;
    public nint pAgpCommitMask;
    public uint dwAgpCommitMaskSize;
}
