namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspenumstorage
[GeneratedComInterface, Guid("1dcb3a15-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPEnumStorage
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumstorage-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, out IMDSPStorage ppStorage, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumstorage-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumstorage-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumstorage-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IMDSPEnumStorage ppEnumStorage);
}
