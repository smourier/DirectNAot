namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspdevice3
[GeneratedComInterface, Guid("1a839845-fc55-487c-976f-ee38ac0e8c4e")]
public partial interface IMDSPDevice3 : IMDSPDevice2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice3-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(PWSTR pwszPropName, out PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice3-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(PWSTR pwszPropName, in PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice3-getformatcapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatCapability(WMDM_FORMATCODE format, out WMDM_FORMAT_CAPABILITY pFormatSupport);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice3-deviceiocontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeviceIoControl(uint dwIoControlCode, nint /* byte array */ lpInBuffer, uint nInBufferSize, nint /* byte array */ lpOutBuffer, ref uint pnOutBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdevice3-findstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindStorage(WMDM_FIND_SCOPE findScope, PWSTR pwszUniqueID, out IMDSPStorage ppStorage);
}
