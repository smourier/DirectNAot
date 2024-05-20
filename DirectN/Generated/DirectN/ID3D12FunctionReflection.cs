#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12functionreflection
[GeneratedComInterface, Guid("1108795c-2772-4ba9-b2a8-d464dc7e2799")]
public partial interface ID3D12FunctionReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D12_FUNCTION_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getconstantbufferbyindex
    [PreserveSig]
    ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint BufferIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getconstantbufferbyname
    [PreserveSig]
    ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getresourcebindingdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceBindingDesc(uint ResourceIndex, out D3D12_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getvariablebyname
    [PreserveSig]
    ID3D12ShaderReflectionVariable GetVariableByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getresourcebindingdescbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceBindingDescByName(PSTR Name, out D3D12_SHADER_INPUT_BIND_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getfunctionparameter
    [PreserveSig]
    ID3D12FunctionParameterReflection GetFunctionParameter(int ParameterIndex);
}
