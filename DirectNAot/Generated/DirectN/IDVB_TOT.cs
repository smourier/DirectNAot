namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvb_tot
[GeneratedComInterface, Guid("83295d6a-faba-4ee1-9b15-8067696910ae")]
public partial interface IDVB_TOT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_tot-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ISectionList pSectionList);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_tot-getutctime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUTCTime(out MPEG_DATE_AND_TIME pmdtVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_tot-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_tot-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_tot-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, nint /* optional uint* */ pdwCookie, out IGenericDescriptor ppDescriptor);
}
