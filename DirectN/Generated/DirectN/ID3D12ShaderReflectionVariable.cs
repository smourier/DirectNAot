#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflectionvariable
public partial struct ID3D12ShaderReflectionVariable
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D12_SHADER_VARIABLE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionVariable*,D3D12_SHADER_VARIABLE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D12ShaderReflectionVariable*)VTablePtr, (D3D12_SHADER_VARIABLE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-gettype
    public readonly unsafe new nint GetType() =>
        ((delegate* unmanaged<ID3D12ShaderReflectionVariable*, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D12ShaderReflectionVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-getbuffer
    public readonly unsafe nint GetBuffer() =>
        ((delegate* unmanaged<ID3D12ShaderReflectionVariable*, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D12ShaderReflectionVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionvariable-getinterfaceslot
    public readonly unsafe uint GetInterfaceSlot(uint uArrayIndex) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionVariable*,uint, uint>)(((void**)*((void**)VTablePtr))[3]))((ID3D12ShaderReflectionVariable*)VTablePtr, uArrayIndex);
}
