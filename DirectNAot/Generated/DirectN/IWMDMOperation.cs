namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmoperation
[GeneratedComInterface, Guid("1dcb3a0b-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IWMDMOperation
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-beginread
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginRead();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-beginwrite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginWrite();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-getobjectname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectName(out PWSTR pwszName, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-setobjectname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjectName(PWSTR pwszName, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-getobjectattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectAttributes(out uint pdwAttributes, nint/* nint */ pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-setobjectattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjectAttributes(uint dwAttributes, nint/* nint */ pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-getobjecttotalsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectTotalSize(out uint pdwSize, out uint pdwSizeHigh);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-setobjecttotalsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjectTotalSize(uint dwSize, uint dwSizeHigh);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-transferobjectdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferObjectData(nint /* byte array */ pData, ref uint pdwSize, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation-end
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End(in HRESULT phCompletionCode, nint pNewObject);
}
