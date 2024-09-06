#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/nn-d3d10shader-id3d10shaderreflectionvariable
public partial struct ID3D10ShaderReflectionVariable
{
    public static readonly ID3D10ShaderReflectionVariable Null = new();
    
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionvariable-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D10_SHADER_VARIABLE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionVariable*,D3D10_SHADER_VARIABLE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D10ShaderReflectionVariable*)VTablePtr, (D3D10_SHADER_VARIABLE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionvariable-gettype
    public readonly unsafe new nint GetType() =>
        ((delegate* unmanaged<ID3D10ShaderReflectionVariable*, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D10ShaderReflectionVariable*)VTablePtr);
}
