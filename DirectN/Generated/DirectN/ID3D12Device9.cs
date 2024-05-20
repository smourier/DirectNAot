#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device9
[GeneratedComInterface, Guid("4c80e962-f032-4f60-bc9e-ebc2cfa1d83c")]
public partial interface ID3D12Device9 : ID3D12Device8
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device9-createshadercachesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShaderCacheSession(in D3D12_SHADER_CACHE_SESSION_DESC pDesc, in Guid riid, out nint /* void */ ppvSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device9-shadercachecontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShaderCacheControl(D3D12_SHADER_CACHE_KIND_FLAGS Kinds, D3D12_SHADER_CACHE_CONTROL_FLAGS Control);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device9-createcommandqueue1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommandQueue1(in D3D12_COMMAND_QUEUE_DESC pDesc, in Guid CreatorID, in Guid riid, out nint /* void */ ppCommandQueue);
}
