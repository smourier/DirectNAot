#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/nn-d3d10shader-id3d10shaderreflectiontype
public partial struct ID3D10ShaderReflectionType
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D10_SHADER_TYPE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionType*,D3D10_SHADER_TYPE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D10ShaderReflectionType*)VTablePtr, (D3D10_SHADER_TYPE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getmembertypebyindex
    public readonly unsafe nint GetMemberTypeByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionType*,uint, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D10ShaderReflectionType*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getmembertypebyname
    public readonly unsafe nint GetMemberTypeByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionType*,PSTR, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D10ShaderReflectionType*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectiontype-getmembertypename
    public readonly unsafe PSTR GetMemberTypeName(uint Index) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionType*,uint, PSTR>)(((void**)*((void**)VTablePtr))[3]))((ID3D10ShaderReflectionType*)VTablePtr, Index);
}
