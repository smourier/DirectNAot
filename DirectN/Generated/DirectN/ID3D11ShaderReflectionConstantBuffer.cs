#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionconstantbuffer
[GeneratedComInterface, Guid("eb62d63d-93dd-4318-8ae8-c6f83ad371b8")]
public partial interface ID3D11ShaderReflectionConstantBuffer
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionconstantbuffer-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3D11_SHADER_BUFFER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionconstantbuffer-getvariablebyindex
    [PreserveSig]
    ID3D11ShaderReflectionVariable GetVariableByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionconstantbuffer-getvariablebyname
    [PreserveSig]
    ID3D11ShaderReflectionVariable GetVariableByName(PSTR Name);
}
