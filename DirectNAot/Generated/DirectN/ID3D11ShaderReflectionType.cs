namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectiontype
[GeneratedComInterface, Guid("6e6ffa6a-9bae-4613-a51e-91652d508c21")]
public partial interface ID3D11ShaderReflectionType
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(out D3D11_SHADER_TYPE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypebyindex
    [PreserveSig]
    public ID3D11ShaderReflectionType GetMemberTypeByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypebyname
    [PreserveSig]
    public ID3D11ShaderReflectionType GetMemberTypeByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypename
    [PreserveSig]
    public PSTR GetMemberTypeName(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsEqual(ID3D11ShaderReflectionType pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getsubtype
    [PreserveSig]
    public ID3D11ShaderReflectionType GetSubType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getbaseclass
    [PreserveSig]
    public ID3D11ShaderReflectionType GetBaseClass();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getnuminterfaces
    [PreserveSig]
    public uint GetNumInterfaces();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getinterfacebyindex
    [PreserveSig]
    public ID3D11ShaderReflectionType GetInterfaceByIndex(uint uIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-isoftype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsOfType(ID3D11ShaderReflectionType pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-implementsinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ImplementsInterface(ID3D11ShaderReflectionType pBase);
}
