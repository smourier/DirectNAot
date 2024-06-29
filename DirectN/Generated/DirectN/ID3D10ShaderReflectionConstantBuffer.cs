#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/nn-d3d10shader-id3d10shaderreflectionconstantbuffer
public partial struct ID3D10ShaderReflectionConstantBuffer
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D10_SHADER_BUFFER_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10ShaderReflectionConstantBuffer*,D3D10_SHADER_BUFFER_DESC*, HRESULT>)(((void**)VTablePtr)[0]))((ID3D10ShaderReflectionConstantBuffer*)VTablePtr, (D3D10_SHADER_BUFFER_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getvariablebyindex
    public unsafe nint GetVariableByIndex(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10ShaderReflectionConstantBuffer*,uint, nint>)(((void**)VTablePtr)[1]))((ID3D10ShaderReflectionConstantBuffer*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-id3d10shaderreflectionconstantbuffer-getvariablebyname
    public unsafe nint GetVariableByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10ShaderReflectionConstantBuffer*,PSTR, nint>)(((void**)VTablePtr)[2]))((ID3D10ShaderReflectionConstantBuffer*)VTablePtr, Name);
    }
}
