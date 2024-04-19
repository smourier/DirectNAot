namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflectiontype
[GeneratedComInterface, Guid("e913c351-783d-48ca-a1d1-4f306284ad56")]
public partial interface ID3D12ShaderReflectionType
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D12_SHADER_TYPE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getmembertypebyindex
    [PreserveSig]
    ID3D12ShaderReflectionType GetMemberTypeByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getmembertypebyname
    [PreserveSig]
    ID3D12ShaderReflectionType GetMemberTypeByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getmembertypename
    [PreserveSig]
    PSTR GetMemberTypeName(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual(ID3D12ShaderReflectionType pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getsubtype
    [PreserveSig]
    ID3D12ShaderReflectionType GetSubType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getbaseclass
    [PreserveSig]
    ID3D12ShaderReflectionType GetBaseClass();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getnuminterfaces
    [PreserveSig]
    uint GetNumInterfaces();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getinterfacebyindex
    [PreserveSig]
    ID3D12ShaderReflectionType GetInterfaceByIndex(uint uIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-isoftype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsOfType(ID3D12ShaderReflectionType pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-implementsinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ImplementsInterface(ID3D12ShaderReflectionType pBase);
}
