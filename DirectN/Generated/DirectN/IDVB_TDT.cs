#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvb_tdt
[GeneratedComInterface, Guid("0780dc7d-d55c-4aef-97e6-6b75906e2796")]
public partial interface IDVB_TDT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_tdt-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ISectionList pSectionList);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_tdt-getutctime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUTCTime(out MPEG_DATE_AND_TIME pmdtVal);
}
