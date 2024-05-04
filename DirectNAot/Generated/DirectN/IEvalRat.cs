#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tvratings/nn-tvratings-ievalrat
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c5c5c5b1-3abc-11d6-b25b-00c04fa0c026")]
public partial interface IEvalRat : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ievalrat-get_blockedratingattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BlockedRatingAttributes(EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, out int plbfAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ievalrat-put_blockedratingattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BlockedRatingAttributes(EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, int lbfAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ievalrat-get_blockunrated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BlockUnRated([MarshalAs(UnmanagedType.U4)] out bool pfBlockUnRatedShows);
    
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ievalrat-put_blockunrated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BlockUnRated([MarshalAs(UnmanagedType.U4)] bool fBlockUnRatedShows);
    
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ievalrat-mostrestrictiverating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MostRestrictiveRating(EnTvRat_System enSystem1, EnTvRat_GenericLevel enEnLevel1, int lbfEnAttr1, EnTvRat_System enSystem2, EnTvRat_GenericLevel enEnLevel2, int lbfEnAttr2, out EnTvRat_System penSystem, out EnTvRat_GenericLevel penEnLevel, out int plbfEnAttr);
    
    // https://learn.microsoft.com/windows/win32/api/tvratings/nf-tvratings-ievalrat-testrating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TestRating(EnTvRat_System enShowSystem, EnTvRat_GenericLevel enShowLevel, int lbfEnShowAttributes);
}
