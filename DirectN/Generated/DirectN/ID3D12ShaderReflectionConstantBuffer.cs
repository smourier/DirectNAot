#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12shaderreflectionconstantbuffer
public partial struct ID3D12ShaderReflectionConstantBuffer
{
    public static readonly ID3D12ShaderReflectionConstantBuffer Null = new();
    
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionconstantbuffer-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D12_SHADER_BUFFER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*,D3D12_SHADER_BUFFER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D12ShaderReflectionConstantBuffer*)VTablePtr, (D3D12_SHADER_BUFFER_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionconstantbuffer-getvariablebyindex
    public readonly unsafe nint GetVariableByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*,uint, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D12ShaderReflectionConstantBuffer*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12shaderreflectionconstantbuffer-getvariablebyname
    public readonly unsafe nint GetVariableByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*,PSTR, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D12ShaderReflectionConstantBuffer*)VTablePtr, Name);
}
