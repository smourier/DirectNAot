#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvb_eit2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("61a389e0-9b9e-4ba0-aeea-5ddd159820ea")]
public partial interface IDVB_EIT2 : IDVB_EIT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_eit2-getsegmentinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentInfo(nint /* byte array */ pbTid, nint /* byte array */ pbSegment);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_eit2-getrecordsection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordSection(uint dwRecordIndex, nint /* byte array */ pbVal);
}
