#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriterpostviewcallback
[GeneratedComInterface, Guid("d9d6549d-a193-4f24-b308-03123d9b7f8d")]
public partial interface IWMWriterPostViewCallback : IWMStatusCallback
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostviewcallback-onpostviewsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPostViewSample(ushort wStreamNumber, ulong cnsSampleTime, ulong cnsSampleDuration, uint dwFlags, INSSBuffer pSample, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostviewcallback-allocateforpostview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateForPostView(ushort wStreamNum, uint cbBuffer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppBuffer, nint pvContext);
}
