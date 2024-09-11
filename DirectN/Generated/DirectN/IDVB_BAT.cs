#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvb_bat
[GeneratedComInterface, Guid("ece9bb0c-43b6-4558-a0ec-1812c34cd6ca")]
public partial interface IDVB_BAT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList>))] ISectionList pSectionList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data>))] IMpeg2Data pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getbouquetid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBouquetId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, in IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, nint /* optional uint* */ pdwCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getrecordtransportstreamid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordTransportStreamId(uint dwRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getrecordoriginalnetworkid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordOriginalNetworkId(uint dwRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getrecordcountofdescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCountOfDescriptors(uint dwRecordIndex, out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getrecorddescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByIndex(uint dwRecordIndex, uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getrecorddescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByTag(uint dwRecordIndex, byte bTag, nint /* optional uint* */ pdwCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-registerfornexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForNextTable(HANDLE hNextTableAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-getnexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextTable([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_BAT>))] out IDVB_BAT ppBAT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-registerforwhencurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForWhenCurrent(HANDLE hNextTableIsCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_bat-convertnexttocurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertNextToCurrent();
}
