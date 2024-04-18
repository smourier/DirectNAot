namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/nn-d3dcommon-id3dinclude
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface ID3DInclude
{
    // https://learn.microsoft.com/windows/win32/api/d3dcommon/nf-d3dcommon-id3dinclude-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Open(D3D_INCLUDE_TYPE IncludeType, PSTR pFileName, nint pParentData, out nint ppData, ref uint pBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcommon/nf-d3dcommon-id3dinclude-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Close(nint pData);
}
