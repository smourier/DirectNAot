#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflectiontype
public partial struct ID3D12ShaderReflectionType
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D12_SHADER_TYPE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,D3D12_SHADER_TYPE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D12ShaderReflectionType*)VTablePtr, (D3D12_SHADER_TYPE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getmembertypebyindex
    public readonly unsafe nint GetMemberTypeByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,uint, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D12ShaderReflectionType*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getmembertypebyname
    public readonly unsafe nint GetMemberTypeByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,PSTR, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D12ShaderReflectionType*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getmembertypename
    public readonly unsafe PSTR GetMemberTypeName(uint Index) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,uint, PSTR>)(((void**)*((void**)VTablePtr))[3]))((ID3D12ShaderReflectionType*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-isequal
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT IsEqual(ID3D12ShaderReflectionType pType) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,ID3D12ShaderReflectionType, HRESULT>)(((void**)*((void**)VTablePtr))[4]))((ID3D12ShaderReflectionType*)VTablePtr, pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getsubtype
    public readonly unsafe nint GetSubType() =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*, nint>)(((void**)*((void**)VTablePtr))[5]))((ID3D12ShaderReflectionType*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getbaseclass
    public readonly unsafe nint GetBaseClass() =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*, nint>)(((void**)*((void**)VTablePtr))[6]))((ID3D12ShaderReflectionType*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getnuminterfaces
    public readonly unsafe uint GetNumInterfaces() =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint>)(((void**)*((void**)VTablePtr))[7]))((ID3D12ShaderReflectionType*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-getinterfacebyindex
    public readonly unsafe nint GetInterfaceByIndex(uint uIndex) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,uint, nint>)(((void**)*((void**)VTablePtr))[8]))((ID3D12ShaderReflectionType*)VTablePtr, uIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-isoftype
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT IsOfType(ID3D12ShaderReflectionType pType) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,ID3D12ShaderReflectionType, HRESULT>)(((void**)*((void**)VTablePtr))[9]))((ID3D12ShaderReflectionType*)VTablePtr, pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectiontype-implementsinterface
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT ImplementsInterface(ID3D12ShaderReflectionType pBase) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionType*,ID3D12ShaderReflectionType, HRESULT>)(((void**)*((void**)VTablePtr))[10]))((ID3D12ShaderReflectionType*)VTablePtr, pBase);
}
