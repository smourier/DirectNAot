namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-idtfilter3
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("513998cc-e929-4cdf-9fbd-bad1e0314866")]
public partial interface IDTFilter3 : IDTFilter2
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter3-getprotectiontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectionType(out ProtType pProtectionType);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter3-licensehasexpirationdate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LicenseHasExpirationDate([MarshalAs(UnmanagedType.U4)] out bool pfLicenseHasExpirationDate);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter3-setrights
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRights(BSTR bstrRights);
}
