namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflectionvariable
[GeneratedComInterface, Guid("8337a8a6-a216-444a-b2f4-314733a73aea")]
public partial interface ID3D12ShaderReflectionVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D12_SHADER_VARIABLE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-gettype
    [PreserveSig]
    ID3D12ShaderReflectionType GetType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-getbuffer
    [PreserveSig]
    ID3D12ShaderReflectionConstantBuffer GetBuffer();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-getinterfaceslot
    [PreserveSig]
    uint GetInterfaceSlot(uint uArrayIndex);
}
