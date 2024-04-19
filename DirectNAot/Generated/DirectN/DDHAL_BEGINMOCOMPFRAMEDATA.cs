namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_BEGINMOCOMPFRAMEDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpDestSurface;
    public uint dwInputDataSize;
    public nint lpInputData;
    public uint dwOutputDataSize;
    public nint lpOutputData;
    public HRESULT ddRVal;
    public nint BeginMoCompFrame;
}
