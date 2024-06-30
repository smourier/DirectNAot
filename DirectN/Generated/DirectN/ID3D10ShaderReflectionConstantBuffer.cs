#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/nn-d3d10shader-id3d10shaderreflectionconstantbuffer
public partial struct ID3D10ShaderReflectionConstantBuffer
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D10_SHADER_BUFFER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*,D3D10_SHADER_BUFFER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D10ShaderReflectionConstantBuffer*)VTablePtr, (D3D10_SHADER_BUFFER_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getvariablebyindex
    public readonly unsafe nint GetVariableByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*,uint, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D10ShaderReflectionConstantBuffer*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getvariablebyname
    public readonly unsafe nint GetVariableByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*,PSTR, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D10ShaderReflectionConstantBuffer*)VTablePtr, Name);
}
