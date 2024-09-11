#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdb_cdt
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("25fa92c2-8b80-4787-a841-3a0e8f17984b")]
public partial interface IISDB_CDT
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList>))] ISectionList pSectionList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data>))] IMpeg2Data pMPEGData, byte bSectionNumber);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getdownloaddataid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDownloadDataId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getsectionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSectionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getoriginalnetworkid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOriginalNetworkId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getdatatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataType(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, nint /* optional uint* */ pdwCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getsizeofdatamodule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSizeOfDataModule(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getdatamodule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataModule(out nint /* byte array */ pbData);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_cdt-getversionhash
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionHash(out uint pdwVersionHash);
}
