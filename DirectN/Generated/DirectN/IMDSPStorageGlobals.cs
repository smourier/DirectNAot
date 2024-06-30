#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspstorageglobals
[GeneratedComInterface, Guid("1dcb3a17-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPStorageGlobals
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out uint pdwCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-getserialnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerialNumber(out WMDMID pSerialNum, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-gettotalsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalSize(out uint pdwTotalSizeLow, out uint pdwTotalSizeHigh);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-gettotalfree
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalFree(out uint pdwFreeLow, out uint pdwFreeHigh);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-gettotalbad
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalBad(out uint pdwBadLow, out uint pdwBadHigh);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(uint fuMode, IWMDMProgress? pProgress);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPDevice>))] out IMDSPDevice ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorageglobals-getrootstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRootStorage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPStorage>))] out IMDSPStorage ppRoot);
}
