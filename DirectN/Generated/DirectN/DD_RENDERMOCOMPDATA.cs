#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_rendermocompdata
public partial struct DD_RENDERMOCOMPDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public uint dwNumBuffers;
    public nint lpBufferInfo;
    public uint dwFunction;
    public nint lpInputData;
    public uint dwInputDataSize;
    public nint lpOutputData;
    public uint dwOutputDataSize;
    public HRESULT ddRVal;
}
