namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_RENDERMOCOMPDATA
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
    public nint RenderMoComp;
}
