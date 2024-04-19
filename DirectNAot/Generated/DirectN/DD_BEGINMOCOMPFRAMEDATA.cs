namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_beginmocompframedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_BEGINMOCOMPFRAMEDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpDestSurface;
    public uint dwInputDataSize;
    public nint lpInputData;
    public uint dwOutputDataSize;
    public nint lpOutputData;
    public HRESULT ddRVal;
}
