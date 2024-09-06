#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmregistercallback
[GeneratedComInterface, Guid("cf4b1f99-4de2-4e49-a363-252740d99bc1")]
public partial interface IWMRegisterCallback
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistercallback-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(IWMStatusCallback pCallback, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistercallback-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(IWMStatusCallback pCallback, nint pvContext);
}
