﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectiontype
public partial struct ID3D11ShaderReflectionType
{
    public static readonly ID3D11ShaderReflectionType Null = new();
    
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D11_SHADER_TYPE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,D3D11_SHADER_TYPE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D11ShaderReflectionType*)VTablePtr, (D3D11_SHADER_TYPE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypebyindex
    public readonly unsafe nint GetMemberTypeByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,uint, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D11ShaderReflectionType*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypebyname
    public readonly unsafe nint GetMemberTypeByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,PSTR, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D11ShaderReflectionType*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getmembertypename
    public readonly unsafe PSTR GetMemberTypeName(uint Index) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,uint, PSTR>)(((void**)*((void**)VTablePtr))[3]))((ID3D11ShaderReflectionType*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-isequal
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT IsEqual(ID3D11ShaderReflectionType pType) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,ID3D11ShaderReflectionType, HRESULT>)(((void**)*((void**)VTablePtr))[4]))((ID3D11ShaderReflectionType*)VTablePtr, pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getsubtype
    public readonly unsafe nint GetSubType() =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*, nint>)(((void**)*((void**)VTablePtr))[5]))((ID3D11ShaderReflectionType*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getbaseclass
    public readonly unsafe nint GetBaseClass() =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*, nint>)(((void**)*((void**)VTablePtr))[6]))((ID3D11ShaderReflectionType*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getnuminterfaces
    public readonly unsafe uint GetNumInterfaces() =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint>)(((void**)*((void**)VTablePtr))[7]))((ID3D11ShaderReflectionType*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-getinterfacebyindex
    public readonly unsafe nint GetInterfaceByIndex(uint uIndex) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,uint, nint>)(((void**)*((void**)VTablePtr))[8]))((ID3D11ShaderReflectionType*)VTablePtr, uIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-isoftype
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT IsOfType(ID3D11ShaderReflectionType pType) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,ID3D11ShaderReflectionType, HRESULT>)(((void**)*((void**)VTablePtr))[9]))((ID3D11ShaderReflectionType*)VTablePtr, pType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectiontype-implementsinterface
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT ImplementsInterface(ID3D11ShaderReflectionType pBase) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionType*,ID3D11ShaderReflectionType, HRESULT>)(((void**)*((void**)VTablePtr))[10]))((ID3D11ShaderReflectionType*)VTablePtr, pBase);
}
