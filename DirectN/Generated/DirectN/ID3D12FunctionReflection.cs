#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12functionreflection
public partial struct ID3D12FunctionReflection
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D12_FUNCTION_DESC pDesc) =>
        ((delegate* unmanaged<ID3D12FunctionReflection*,D3D12_FUNCTION_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D12FunctionReflection*)VTablePtr, (D3D12_FUNCTION_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getconstantbufferbyindex
    public readonly unsafe nint GetConstantBufferByIndex(uint BufferIndex) =>
        ((delegate* unmanaged<ID3D12FunctionReflection*,uint, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D12FunctionReflection*)VTablePtr, BufferIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getconstantbufferbyname
    public readonly unsafe nint GetConstantBufferByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D12FunctionReflection*,PSTR, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D12FunctionReflection*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getresourcebindingdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetResourceBindingDesc(uint ResourceIndex, ref D3D12_SHADER_INPUT_BIND_DESC pDesc) =>
        ((delegate* unmanaged<ID3D12FunctionReflection*,uint,D3D12_SHADER_INPUT_BIND_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[3]))((ID3D12FunctionReflection*)VTablePtr, ResourceIndex, (D3D12_SHADER_INPUT_BIND_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getvariablebyname
    public readonly unsafe nint GetVariableByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D12FunctionReflection*,PSTR, nint>)(((void**)*((void**)VTablePtr))[4]))((ID3D12FunctionReflection*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getresourcebindingdescbyname
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetResourceBindingDescByName(PSTR Name, ref D3D12_SHADER_INPUT_BIND_DESC pDesc) =>
        ((delegate* unmanaged<ID3D12FunctionReflection*,PSTR,D3D12_SHADER_INPUT_BIND_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[5]))((ID3D12FunctionReflection*)VTablePtr, Name, (D3D12_SHADER_INPUT_BIND_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionreflection-getfunctionparameter
    public readonly unsafe nint GetFunctionParameter(int ParameterIndex) =>
        ((delegate* unmanaged<ID3D12FunctionReflection*,int, nint>)(((void**)*((void**)VTablePtr))[6]))((ID3D12FunctionReflection*)VTablePtr, ParameterIndex);
}
