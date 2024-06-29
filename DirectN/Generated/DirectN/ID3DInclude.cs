#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/nn-d3dcommon-id3dinclude
public partial struct ID3DInclude
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3dcommon/nf-d3dcommon-id3dinclude-open
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT Open(D3D_INCLUDE_TYPE IncludeType, PSTR pFileName, nint pParentData, ref nint ppData, ref uint pBytes)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DInclude*,D3D_INCLUDE_TYPE,PSTR,nint,nint*,uint*, HRESULT>)(((void**)VTablePtr)[0]))((ID3DInclude*)VTablePtr, IncludeType, pFileName, pParentData, (nint*)Unsafe.AsPointer(ref ppData), (uint*)Unsafe.AsPointer(ref pBytes));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3dcommon/nf-d3dcommon-id3dinclude-close
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT Close(nint pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DInclude*,nint, HRESULT>)(((void**)VTablePtr)[1]))((ID3DInclude*)VTablePtr, pData);
    }
}
