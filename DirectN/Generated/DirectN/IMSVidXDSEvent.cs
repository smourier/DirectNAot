#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidxdsevent
[GeneratedComInterface, Guid("6db2317d-3b23-41ec-ba4b-701f407eaf3a")]
public partial interface IMSVidXDSEvent : IMSVidFeatureEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidxdsevent-ratingchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RatingChange(EnTvRat_System PrevRatingSystem, EnTvRat_GenericLevel PrevLevel, BfEnTvRat_GenericAttributes PrevAttributes, EnTvRat_System NewRatingSystem, EnTvRat_GenericLevel NewLevel, BfEnTvRat_GenericAttributes NewAttributes);
}
