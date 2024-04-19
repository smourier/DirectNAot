namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-ietfilter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c4c4c4b1-0049-4e2b-98fb-9537f6ce516d")]
public partial interface IETFilter
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ietfilter-get_evalratobjok
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EvalRatObjOK(out HRESULT pHrCoCreateRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ietfilter-getcurrrating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrRating(out EnTvRat_System pEnSystem, out EnTvRat_GenericLevel pEnRating, out int plbfEnAttr);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ietfilter-getcurrlicenseexpdate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrLicenseExpDate(in ProtType protType, out int lpDateTime);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ietfilter-getlasterrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastErrorCode();
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ietfilter-setrecordingon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecordingOn([MarshalAs(UnmanagedType.U4)] bool fRecState);
}
