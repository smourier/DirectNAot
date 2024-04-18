namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-icreateerrorinfo
[GeneratedComInterface, Guid("22f03340-547d-101b-8e65-08002b2bd119")]
public partial interface ICreateErrorInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-icreateerrorinfo-setguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGUID(in Guid rguid);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-icreateerrorinfo-setsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSource(PWSTR szSource);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-icreateerrorinfo-setdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDescription(PWSTR szDescription);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-icreateerrorinfo-sethelpfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetHelpFile(PWSTR szHelpFile);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-icreateerrorinfo-sethelpcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetHelpContext(uint dwHelpContext);
}
