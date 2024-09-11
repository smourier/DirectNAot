#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/atscpsipparser/nn-atscpsipparser-iatsc_stt
[GeneratedComInterface, Guid("6bf42423-217d-4d6f-81e1-3a7b360ec896")]
public partial interface IATSC_STT
{
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList?>))] ISectionList? pSectionList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data?>))] IMpeg2Data? pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-getprotocolversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtocolVersion(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-getsystemtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemTime(out MPEG_DATE_AND_TIME pmdtSystemTime);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-getgpsutcoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGpsUtcOffset(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-getdaylightsavings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDaylightSavings(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_stt-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, ref uint pdwCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
}
