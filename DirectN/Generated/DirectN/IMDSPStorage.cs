#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspstorage
[GeneratedComInterface, Guid("1dcb3a16-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPStorage
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-setattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttributes(uint dwAttributes, nint /* optional WAVEFORMATEX* */ pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-getstorageglobals
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorageGlobals(out IMDSPStorageGlobals ppStorageGlobals);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-getattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes(out uint pdwAttributes, nint /* optional WAVEFORMATEX* */ pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(CountElementName = nameof(nMaxChars))] PWSTR pwszName, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-getdate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDate(out WMDMDATETIME pDateTimeUTC);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(out uint pdwSizeLow, out uint pdwSizeHigh);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-getrights
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRights(out nint ppRights, out uint pnRightsCount, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-createstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStorage(uint dwAttributes, nint /* optional WAVEFORMATEX* */ pFormat, PWSTR pwszName, out IMDSPStorage ppNewStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-enumstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumStorage(out IMDSPEnumStorage ppEnumStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage-sendopaquecommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendOpaqueCommand(ref OPAQUECOMMAND pCommand);
}
