namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbterrestrialdeliverysystemdescriptor
[GeneratedComInterface, Guid("ed7e1b91-d12e-420c-b41d-a49d84fe1823")]
public partial interface IDvbTerrestrialDeliverySystemDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getcentrefrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCentreFrequency(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandwidth(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getconstellation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConstellation(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-gethierarchyinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHierarchyInformation(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getcoderatehpstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodeRateHPStream(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getcoderatelpstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodeRateLPStream(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getguardinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuardInterval(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-gettransmissionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransmissionMode(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbterrestrialdeliverysystemdescriptor-getotherfrequencyflag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOtherFrequencyFlag(nint /* byte array */ pbVal);
}
