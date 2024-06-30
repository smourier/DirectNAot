#nullable enable
namespace DirectN;

public partial struct DDHAL_ENDMOCOMPFRAMEDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpInputData;
    public uint dwInputDataSize;
    public HRESULT ddRVal;
    public nint EndMoCompFrame;
}
