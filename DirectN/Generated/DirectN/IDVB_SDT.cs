#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvb_sdt
[GeneratedComInterface, Guid("02cad8d3-fe43-48e2-90bd-450ed9a8a5fd")]
public partial interface IDVB_SDT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList>))] ISectionList pSectionList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data>))] IMpeg2Data pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-gettransportstreamid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransportStreamId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getoriginalnetworkid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOriginalNetworkId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecordserviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordServiceId(uint dwRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecordeitscheduleflag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordEITScheduleFlag(uint dwRecordIndex, out BOOL pfVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecordeitpresentfollowingflag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordEITPresentFollowingFlag(uint dwRecordIndex, out BOOL pfVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecordrunningstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordRunningStatus(uint dwRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecordfreecamode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordFreeCAMode(uint dwRecordIndex, out BOOL pfVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecordcountofdescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCountOfDescriptors(uint dwRecordIndex, out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecorddescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByIndex(uint dwRecordIndex, uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getrecorddescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByTag(uint dwRecordIndex, byte bTag, nint /* optional uint* */ pdwCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-registerfornexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForNextTable(HANDLE hNextTableAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getnexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextTable([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_SDT>))] out IDVB_SDT ppSDT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-registerforwhencurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForWhenCurrent(HANDLE hNextTableIsCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-convertnexttocurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertNextToCurrent();
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_sdt-getversionhash
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionHash(out uint pdwVersionHash);
}
