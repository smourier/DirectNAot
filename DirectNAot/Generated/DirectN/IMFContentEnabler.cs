namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcontentenabler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d3c4ef59-49ce-4381-9071-d5bcd044c770")]
public partial interface IMFContentEnabler
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentenabler-getenabletype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableType(out Guid pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentenabler-getenableurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableURL(out PWSTR ppwszURL, out uint pcchURL, ref MF_URL_TRUST_STATUS pTrustStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentenabler-getenabledata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableData(out nint /* byte array */ ppbData, out uint pcbData);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentenabler-isautomaticsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAutomaticSupported([MarshalAs(UnmanagedType.U4)] out bool pfAutomatic);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentenabler-automaticenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AutomaticEnable();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentenabler-monitorenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MonitorEnable();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentenabler-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
