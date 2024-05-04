#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nn-mpeg2psiparser-itsdt
[GeneratedComInterface, Guid("d19bdb43-405b-4a7c-a791-c89110c33165")]
public partial interface ITSDT
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ISectionList pSectionList, IMpeg2Data pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, ref uint pdwCookie, out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-registerfornexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForNextTable(HANDLE hNextTableAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-getnexttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextTable(out ITSDT ppTSDT);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-registerforwhencurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForWhenCurrent(HANDLE hNextTableIsCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-itsdt-convertnexttocurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertNextToCurrent();
}
