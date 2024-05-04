#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nn-mpeg2psiparser-icat
[GeneratedComInterface, Guid("7c6995fb-2a31-4bd7-953e-b1ad7fb7d31c")]
public partial interface ICAT
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ISectionList pSectionList, IMpeg2Data pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, ref uint pdwCookie, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-registerfornexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForNextTable(HANDLE hNextTableAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-getnexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextTable(uint dwTimeout, out ICAT ppCAT);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-registerforwhencurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForWhenCurrent(HANDLE hNextTableIsCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-icat-convertnexttocurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertNextToCurrent();
}
