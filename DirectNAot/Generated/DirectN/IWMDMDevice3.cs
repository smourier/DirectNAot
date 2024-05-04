#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmdevice3
[GeneratedComInterface, Guid("6c03e4fe-05db-4dda-9e3c-06233a6d5d65")]
public partial interface IWMDMDevice3 : IWMDMDevice2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice3-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(PWSTR pwszPropName, out PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice3-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(PWSTR pwszPropName, in PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice3-getformatcapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatCapability(WMDM_FORMATCODE format, out WMDM_FORMAT_CAPABILITY pFormatSupport);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice3-deviceiocontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeviceIoControl(uint dwIoControlCode, nint /* byte array */ lpInBuffer, uint nInBufferSize, nint /* byte array */ lpOutBuffer, ref uint pnOutBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevice3-findstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindStorage(WMDM_FIND_SCOPE findScope, PWSTR pwszUniqueID, out IWMDMStorage ppStorage);
}
