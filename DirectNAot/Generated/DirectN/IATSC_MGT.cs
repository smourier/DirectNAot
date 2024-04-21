namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/atscpsipparser/nn-atscpsipparser-iatsc_mgt
[GeneratedComInterface, Guid("8877dabd-c137-4073-97e3-779407a5d87a")]
public partial interface IATSC_MGT
{
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ISectionList? pSectionList, IMpeg2Data? pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getprotocolversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtocolVersion(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getrecordtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordType(uint dwRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getrecordtypepid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordTypePid(uint dwRecordIndex, out ushort ppidVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getrecordversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordVersionNumber(uint dwRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getrecordcountofdescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCountOfDescriptors(uint dwRecordIndex, out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getrecorddescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByIndex(uint dwRecordIndex, uint dwIndex, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getrecorddescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordDescriptorByTag(uint dwRecordIndex, byte bTag, ref uint pdwCookie, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(in uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_mgt-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, ref uint pdwCookie, out IGenericDescriptor ppDescriptor);
}
