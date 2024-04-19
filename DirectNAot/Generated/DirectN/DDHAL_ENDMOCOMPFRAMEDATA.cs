namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_ENDMOCOMPFRAMEDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpInputData;
    public uint dwInputDataSize;
    public HRESULT ddRVal;
    public nint EndMoCompFrame;
}
