namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_decodeextensiondata
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_DecodeExtensionData
{
    public uint Function;
    public nint pPrivateInputData;
    public uint PrivateInputDataSize;
    public nint pPrivateOutputData;
    public uint PrivateOutputDataSize;
}
