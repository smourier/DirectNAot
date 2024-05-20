#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflectionconstantbuffer
[GeneratedComInterface, Guid("c59598b4-48b3-4869-b9b1-b1618b14a8b7")]
public partial interface ID3D12ShaderReflectionConstantBuffer
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionconstantbuffer-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3D12_SHADER_BUFFER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionconstantbuffer-getvariablebyindex
    [PreserveSig]
    ID3D12ShaderReflectionVariable GetVariableByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionconstantbuffer-getvariablebyname
    [PreserveSig]
    ID3D12ShaderReflectionVariable GetVariableByName(PSTR Name);
}
