﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_decodeextensiondata
public partial struct DXVA2_DecodeExtensionData
{
    public uint Function;
    public nint pPrivateInputData;
    public uint PrivateInputDataSize;
    public nint pPrivateOutputData;
    public uint PrivateOutputDataSize;
}
