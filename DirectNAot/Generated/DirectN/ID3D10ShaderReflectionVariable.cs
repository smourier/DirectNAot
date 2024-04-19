namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/nn-d3d10shader-id3d10shaderreflectionvariable
[GeneratedComInterface, Guid("1bf63c95-2650-405d-99c1-3636bd1da0a1")]
public partial interface ID3D10ShaderReflectionVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionvariable-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D10_SHADER_VARIABLE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionvariable-gettype
    [PreserveSig]
    ID3D10ShaderReflectionType GetType();
}
