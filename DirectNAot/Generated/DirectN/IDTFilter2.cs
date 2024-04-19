namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-idtfilter2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c4c4c4b4-0049-4e2b-98fb-9537f6ce516d")]
public partial interface IDTFilter2 : IDTFilter
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter2-get_challengeurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ChallengeUrl(out BSTR pbstrChallengeUrl);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter2-getcurrlicenseexpdate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrLicenseExpDate(in ProtType protType, out int lpDateTime);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter2-getlasterrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastErrorCode();
}
