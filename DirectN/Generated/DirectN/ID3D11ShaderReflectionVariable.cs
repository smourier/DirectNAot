#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11shaderreflectionvariable
public partial struct ID3D11ShaderReflectionVariable
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D11_SHADER_VARIABLE_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionVariable*,D3D11_SHADER_VARIABLE_DESC*, HRESULT>)(((void**)VTablePtr)[0]))((ID3D11ShaderReflectionVariable*)VTablePtr, (D3D11_SHADER_VARIABLE_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-gettype
    public unsafe new nint GetType()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionVariable*, nint>)(((void**)VTablePtr)[1]))((ID3D11ShaderReflectionVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getbuffer
    public unsafe nint GetBuffer()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionVariable*, nint>)(((void**)VTablePtr)[2]))((ID3D11ShaderReflectionVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11shaderreflectionvariable-getinterfaceslot
    public unsafe uint GetInterfaceSlot(uint uArrayIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderReflectionVariable*,uint, uint>)(((void**)VTablePtr)[3]))((ID3D11ShaderReflectionVariable*)VTablePtr, uArrayIndex);
    }
}
