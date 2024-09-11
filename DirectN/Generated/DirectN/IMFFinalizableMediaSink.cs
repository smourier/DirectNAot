#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imffinalizablemediasink
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("eaecb74a-9a50-42ce-9541-6a7f57aa4ad7")]
public partial interface IMFFinalizableMediaSink : IMFMediaSink
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imffinalizablemediasink-beginfinalize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginFinalize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imffinalizablemediasink-endfinalize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndFinalize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult);
}
