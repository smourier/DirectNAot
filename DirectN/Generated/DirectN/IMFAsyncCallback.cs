#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfasynccallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a27003cf-2354-4f2a-8d6a-ab7cff15437e")]
public partial interface IMFAsyncCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasynccallback-getparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameters(out uint pdwFlags, out uint pdwQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasynccallback-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pAsyncResult);
}
