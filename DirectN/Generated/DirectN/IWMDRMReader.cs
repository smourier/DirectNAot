#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmreader
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d2827540-3ee7-432c-b14c-dc17f085d3b3")]
public partial interface IWMDRMReader
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-acquirelicense
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireLicense(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-cancellicenseacquisition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelLicenseAcquisition();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-individualize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Individualize(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-cancelindividualization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelIndividualization();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-monitorlicenseacquisition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MonitorLicenseAcquisition();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-cancelmonitorlicenseacquisition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelMonitorLicenseAcquisition();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-setdrmproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDRMProperty(PWSTR pwstrName, WMT_ATTR_DATATYPE dwType, nint /* byte array */ pValue, ushort cbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader-getdrmproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDRMProperty(PWSTR pwstrName, out WMT_ATTR_DATATYPE pdwType, nint /* byte array */ pValue, ref ushort pcbLength);
}
