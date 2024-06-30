#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_updatenonlocalheapdata
public partial struct DD_UPDATENONLOCALHEAPDATA
{
    public nint lpDD;
    public uint dwHeap;
    public nuint fpGARTLin;
    public nuint fpGARTDev;
    public nuint ulPolicyMaxBytes;
    public HRESULT ddRVal;
    public nint UpdateNonLocalHeap;
}
