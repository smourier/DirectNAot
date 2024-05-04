#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmdevice
[GeneratedComInterface, Guid("1dcb3a02-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IWMDMDevice
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(CountElementName = nameof(nMaxChars))] out PWSTR[] pwszName, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getmanufacturer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetManufacturer([MarshalUsing(CountElementName = nameof(nMaxChars))] out PWSTR[] pwszName, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersion(out uint pdwVersion);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out uint pdwType);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getserialnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerialNumber(out WMDMID pSerialNumber, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getpowersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPowerSource(out uint pdwPowerSource, out uint pdwPercentRemaining);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getdeviceicon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceIcon(out uint hIcon);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-enumstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumStorage(out IWMDMEnumStorage ppEnumStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-getformatsupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatSupport(out nint ppFormatEx, out uint pnFormatCount, out nint pppwszMimeType, out uint pnMimeTypeCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice-sendopaquecommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendOpaqueCommand(ref OPAQUECOMMAND pCommand);
}
