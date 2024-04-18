namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/nn-d3d10shader-id3d10shaderreflectiontype
[GeneratedComInterface, Guid("c530ad7d-9b16-4395-a979-ba2ecff83add")]
public partial interface ID3D10ShaderReflectionType
{
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(ref D3D10_SHADER_TYPE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getmembertypebyindex
    [PreserveSig]
    public ID3D10ShaderReflectionType GetMemberTypeByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getmembertypebyname
    [PreserveSig]
    public ID3D10ShaderReflectionType GetMemberTypeByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getmembertypename
    [PreserveSig]
    public PSTR GetMemberTypeName(uint Index);
}
