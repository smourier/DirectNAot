#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionconstantbuffer
public partial struct ID3D11ShaderReflectionConstantBuffer
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionconstantbuffer-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D11_SHADER_BUFFER_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionConstantBuffer*,D3D11_SHADER_BUFFER_DESC*, HRESULT>)(((void**)VTablePtr)[0]))((ID3D11ShaderReflectionConstantBuffer*)VTablePtr, (D3D11_SHADER_BUFFER_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionconstantbuffer-getvariablebyindex
    public unsafe nint GetVariableByIndex(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionConstantBuffer*,uint, nint>)(((void**)VTablePtr)[1]))((ID3D11ShaderReflectionConstantBuffer*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionconstantbuffer-getvariablebyname
    public unsafe nint GetVariableByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionConstantBuffer*,PSTR, nint>)(((void**)VTablePtr)[2]))((ID3D11ShaderReflectionConstantBuffer*)VTablePtr, Name);
    }
}
