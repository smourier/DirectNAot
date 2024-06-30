#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionvariable
public partial struct ID3D11ShaderReflectionVariable
{
    public static readonly ID3D11ShaderReflectionVariable Null = new();
    
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D11_SHADER_VARIABLE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionVariable*,D3D11_SHADER_VARIABLE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D11ShaderReflectionVariable*)VTablePtr, (D3D11_SHADER_VARIABLE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-gettype
    public readonly unsafe new nint GetType() =>
        ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D11ShaderReflectionVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getbuffer
    public readonly unsafe nint GetBuffer() =>
        ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D11ShaderReflectionVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getinterfaceslot
    public readonly unsafe uint GetInterfaceSlot(uint uArrayIndex) =>
        ((delegate* unmanaged<ID3D11ShaderReflectionVariable*,uint, uint>)(((void**)*((void**)VTablePtr))[3]))((ID3D11ShaderReflectionVariable*)VTablePtr, uArrayIndex);
}
