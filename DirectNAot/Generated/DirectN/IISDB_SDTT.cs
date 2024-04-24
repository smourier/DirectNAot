namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdb_sdtt
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ee60ef2d-813a-4dc7-bf92-ea13dac85313")]
public partial interface IISDB_SDTT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ISectionList pSectionList, IMpeg2Data pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-gettableidext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableIdExt(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-gettransportstreamid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransportStreamId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getoriginalnetworkid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOriginalNetworkId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getserviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordGroup(uint dwRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordtargetversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordTargetVersion(uint dwRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordnewversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordNewVersion(uint dwRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecorddownloadlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDownloadLevel(uint dwRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordversionindicator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordVersionIndicator(uint dwRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordscheduletimeshiftinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordScheduleTimeShiftInformation(uint dwRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordcountofschedules
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCountOfSchedules(uint dwRecordIndex, out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordstarttimebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordStartTimeByIndex(uint dwRecordIndex, uint dwIndex, out MPEG_DATE_AND_TIME pmdtVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecorddurationbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDurationByIndex(uint dwRecordIndex, uint dwIndex, out MPEG_TIME pmdVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecordcountofdescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCountOfDescriptors(uint dwRecordIndex, out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecorddescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByIndex(uint dwRecordIndex, uint dwIndex, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getrecorddescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByTag(uint dwRecordIndex, byte bTag, nint /* optional uint* */ pdwCookie, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_sdtt-getversionhash
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionHash(out uint pdwVersionHash);
}
