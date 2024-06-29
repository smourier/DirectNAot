#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectiontype
public partial struct ID3D11ShaderReflectionType
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D11_SHADER_TYPE_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,D3D11_SHADER_TYPE_DESC*, HRESULT>)(((void**)VTablePtr)[0]))((ID3D11ShaderReflectionType*)VTablePtr, (D3D11_SHADER_TYPE_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypebyindex
    public unsafe nint GetMemberTypeByIndex(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,uint, nint>)(((void**)VTablePtr)[1]))((ID3D11ShaderReflectionType*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypebyname
    public unsafe nint GetMemberTypeByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,PSTR, nint>)(((void**)VTablePtr)[2]))((ID3D11ShaderReflectionType*)VTablePtr, Name);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypename
    public unsafe PSTR GetMemberTypeName(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,uint, PSTR>)(((void**)VTablePtr)[3]))((ID3D11ShaderReflectionType*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-isequal
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT IsEqual(ID3D11ShaderReflectionType pType)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,ID3D11ShaderReflectionType, HRESULT>)(((void**)VTablePtr)[4]))((ID3D11ShaderReflectionType*)VTablePtr, pType);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getsubtype
    public unsafe nint GetSubType()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*, nint>)(((void**)VTablePtr)[5]))((ID3D11ShaderReflectionType*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getbaseclass
    public unsafe nint GetBaseClass()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*, nint>)(((void**)VTablePtr)[6]))((ID3D11ShaderReflectionType*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getnuminterfaces
    public unsafe uint GetNumInterfaces()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*, uint>)(((void**)VTablePtr)[7]))((ID3D11ShaderReflectionType*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getinterfacebyindex
    public unsafe nint GetInterfaceByIndex(uint uIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,uint, nint>)(((void**)VTablePtr)[8]))((ID3D11ShaderReflectionType*)VTablePtr, uIndex);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-isoftype
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT IsOfType(ID3D11ShaderReflectionType pType)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,ID3D11ShaderReflectionType, HRESULT>)(((void**)VTablePtr)[9]))((ID3D11ShaderReflectionType*)VTablePtr, pType);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-implementsinterface
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT ImplementsInterface(ID3D11ShaderReflectionType pBase)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionType*,ID3D11ShaderReflectionType, HRESULT>)(((void**)VTablePtr)[10]))((ID3D11ShaderReflectionType*)VTablePtr, pBase);
    }
}
