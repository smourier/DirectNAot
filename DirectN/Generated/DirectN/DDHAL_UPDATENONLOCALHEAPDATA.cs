#nullable enable
namespace DirectN;

public partial struct DDHAL_UPDATENONLOCALHEAPDATA
{
    public nint lpDD;
    public uint dwHeap;
    public nuint fpGARTLin;
    public nuint fpGARTDev;
    public nuint ulPolicyMaxBytes;
    public HRESULT ddRVal;
    public nint UpdateNonLocalHeap;
}
