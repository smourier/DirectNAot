#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvblogicalchannel2descriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f69c3747-8a30-4980-998c-01fe7f0ba35a")]
public partial interface IDvbLogicalChannel2Descriptor : IDvbLogicalChannelDescriptor2
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getcountoflists
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfLists(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getlistid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListId(byte bListIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getlistnamew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListNameW(byte bListIndex, DVB_STRCONV_MODE convMode, out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getlistcountrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListCountryCode(byte bListIndex, nint /* byte array */ pszCode);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getlistcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListCountOfRecords(byte bChannelListIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getlistrecordserviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListRecordServiceId(byte bListIndex, byte bRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getlistrecordlogicalchannelnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListRecordLogicalChannelNumber(byte bListIndex, byte bRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvblogicalchannel2descriptor-getlistrecordlogicalchannelandvisibility
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListRecordLogicalChannelAndVisibility(byte bListIndex, byte bRecordIndex, out ushort pwVal);
}
