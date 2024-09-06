#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspdevice
[GeneratedComInterface, Guid("1dcb3a12-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPDevice
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(CountElementName = nameof(nMaxChars))] PWSTR pwszName, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getmanufacturer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetManufacturer([MarshalUsing(CountElementName = nameof(nMaxChars))] PWSTR pwszName, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersion(out uint pdwVersion);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out uint pdwType);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getserialnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerialNumber(out WMDMID pSerialNumber, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getpowersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPowerSource(out uint pdwPowerSource, out uint pdwPercentRemaining);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getdeviceicon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceIcon(out uint hIcon);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-enumstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumStorage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPEnumStorage>))] out IMDSPEnumStorage ppEnumStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-getformatsupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatSupport(out nint pFormatEx, out uint pnFormatCount, out nint pppwszMimeType, out uint pnMimeTypeCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice-sendopaquecommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendOpaqueCommand(ref OPAQUECOMMAND pCommand);
}
