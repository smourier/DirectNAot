#nullable enable
namespace DirectN;

public partial struct DDHAL_WAITFORVPORTSYNCDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public uint dwLine;
    public uint dwTimeOut;
    public HRESULT ddRVal;
    public nint WaitForVideoPortSync;
}
