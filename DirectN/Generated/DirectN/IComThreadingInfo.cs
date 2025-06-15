#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-icomthreadinginfo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("000001ce-0000-0000-c000-000000000046")]
public partial interface IComThreadingInfo
{
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-icomthreadinginfo-getcurrentapartmenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentApartmentType(out APTTYPE pAptType);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-icomthreadinginfo-getcurrentthreadtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentThreadType(out THDTYPE pThreadType);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-icomthreadinginfo-getcurrentlogicalthreadid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentLogicalThreadId(out Guid pguidLogicalThreadId);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-icomthreadinginfo-setcurrentlogicalthreadid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentLogicalThreadId(in Guid rguid);
}
