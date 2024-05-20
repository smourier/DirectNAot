#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionvariable
[GeneratedComInterface, Guid("51f23923-f3e5-4bd1-91cb-606177d8db4c")]
public partial interface ID3D11ShaderReflectionVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D11_SHADER_VARIABLE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-gettype
    [PreserveSig]
    ID3D11ShaderReflectionType GetType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getbuffer
    [PreserveSig]
    ID3D11ShaderReflectionConstantBuffer GetBuffer();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getinterfaceslot
    [PreserveSig]
    uint GetInterfaceSlot(uint uArrayIndex);
}
