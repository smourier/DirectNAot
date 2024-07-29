#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-ierrorinfo
[GeneratedComInterface, Guid("1cf2b120-547d-101b-8e65-08002b2bd119")]
public partial interface IErrorInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ierrorinfo-getguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGUID(out Guid pGUID);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ierrorinfo-getsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSource(out BSTR pBstrSource);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ierrorinfo-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription(out BSTR pBstrDescription);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ierrorinfo-gethelpfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHelpFile(out BSTR pBstrHelpFile);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ierrorinfo-gethelpcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHelpContext(out uint pdwHelpContext);
}
