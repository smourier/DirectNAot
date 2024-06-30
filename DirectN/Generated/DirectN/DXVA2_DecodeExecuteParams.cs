#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_decodeexecuteparams
public partial struct DXVA2_DecodeExecuteParams
{
    public uint NumCompBuffers;
    public nint pCompressedBuffers;
    public nint pExtensionData;
}
