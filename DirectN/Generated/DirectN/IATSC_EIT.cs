#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/atscpsipparser/nn-atscpsipparser-iatsc_eit
[GeneratedComInterface, Guid("d7c212d7-76a2-4b4b-aa56-846879a80096")]
public partial interface IATSC_EIT
{
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList?>))] ISectionList? pSectionList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data?>))] IMpeg2Data? pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getprotocolversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtocolVersion(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecordeventid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordEventId(uint dwRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecordstarttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordStartTime(uint dwRecordIndex, out MPEG_DATE_AND_TIME pmdtVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecordetmlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordEtmLocation(uint dwRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecordduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDuration(uint dwRecordIndex, out MPEG_TIME pmdVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecordtitletext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordTitleText(uint dwRecordIndex, out uint pdwLength, out nint /* byte array */ ppText);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecordcountofdescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCountOfDescriptors(uint dwRecordIndex, out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecorddescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByIndex(uint dwRecordIndex, uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_eit-getrecorddescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByTag(uint dwRecordIndex, byte bTag, ref uint pdwCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
}
