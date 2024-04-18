namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/nn-d3d10shader-id3d10shaderreflectionconstantbuffer
[GeneratedComInterface, Guid("66c66a94-dddd-4b62-a66a-f0da33c2b4d0")]
public partial interface ID3D10ShaderReflectionConstantBuffer
{
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(out D3D10_SHADER_BUFFER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getvariablebyindex
    [PreserveSig]
    public ID3D10ShaderReflectionVariable GetVariableByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getvariablebyname
    [PreserveSig]
    public ID3D10ShaderReflectionVariable GetVariableByName(PSTR Name);
}
