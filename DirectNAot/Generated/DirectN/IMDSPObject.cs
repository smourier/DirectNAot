namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspobject
[GeneratedComInterface, Guid("1dcb3a18-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPObject
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(uint fuMode);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-read
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(nint /* byte array */ pData, ref uint pdwSize, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-write
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(nint /* byte array */ pData, ref uint pdwSize, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(uint fuMode, IWMDMProgress pProgress);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(uint fuFlags, uint dwOffset);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-rename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Rename(PWSTR pwszNewName, IWMDMProgress pProgress);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-move
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move(uint fuMode, IWMDMProgress pProgress, IMDSPStorage pTarget);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
