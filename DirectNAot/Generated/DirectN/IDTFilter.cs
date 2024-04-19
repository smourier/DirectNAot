namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-idtfilter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c4c4c4b2-0049-4e2b-98fb-9537f6ce516d")]
public partial interface IDTFilter
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-get_evalratobjok
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EvalRatObjOK(out HRESULT pHrCoCreateRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-getcurrrating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrRating(out EnTvRat_System pEnSystem, out EnTvRat_GenericLevel pEnRating, out int plbfEnAttr);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-get_blockedratingattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BlockedRatingAttributes(EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, out int plbfEnAttr);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-put_blockedratingattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BlockedRatingAttributes(EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, int lbfAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-get_blockunrated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BlockUnRated([MarshalAs(UnmanagedType.U4)] out bool pfBlockUnRatedShows);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-put_blockunrated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BlockUnRated([MarshalAs(UnmanagedType.U4)] bool fBlockUnRatedShows);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-get_blockunrateddelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BlockUnRatedDelay(out int pmsecsDelayBeforeBlock);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilter-put_blockunrateddelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BlockUnRatedDelay(int msecsDelayBeforeBlock);
}
