#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11functionreflection
public partial struct ID3D11FunctionReflection
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionreflection-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D11_FUNCTION_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11FunctionReflection*,D3D11_FUNCTION_DESC*, HRESULT>)(((void**)VTablePtr)[0]))((ID3D11FunctionReflection*)VTablePtr, (D3D11_FUNCTION_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionreflection-getconstantbufferbyindex
    public unsafe nint GetConstantBufferByIndex(uint BufferIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11FunctionReflection*,uint, nint>)(((void**)VTablePtr)[1]))((ID3D11FunctionReflection*)VTablePtr, BufferIndex);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionreflection-getconstantbufferbyname
    public unsafe nint GetConstantBufferByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11FunctionReflection*,PSTR, nint>)(((void**)VTablePtr)[2]))((ID3D11FunctionReflection*)VTablePtr, Name);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetResourceBindingDesc(uint ResourceIndex, ref D3D11_SHADER_INPUT_BIND_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11FunctionReflection*,uint,D3D11_SHADER_INPUT_BIND_DESC*, HRESULT>)(((void**)VTablePtr)[3]))((ID3D11FunctionReflection*)VTablePtr, ResourceIndex, (D3D11_SHADER_INPUT_BIND_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionreflection-getvariablebyname
    public unsafe nint GetVariableByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11FunctionReflection*,PSTR, nint>)(((void**)VTablePtr)[4]))((ID3D11FunctionReflection*)VTablePtr, Name);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionreflection-getresourcebindingdescbyname
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetResourceBindingDescByName(PSTR Name, ref D3D11_SHADER_INPUT_BIND_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11FunctionReflection*,PSTR,D3D11_SHADER_INPUT_BIND_DESC*, HRESULT>)(((void**)VTablePtr)[5]))((ID3D11FunctionReflection*)VTablePtr, Name, (D3D11_SHADER_INPUT_BIND_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionreflection-getfunctionparameter
    public unsafe nint GetFunctionParameter(int ParameterIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11FunctionReflection*,int, nint>)(((void**)VTablePtr)[6]))((ID3D11FunctionReflection*)VTablePtr, ParameterIndex);
    }
}
