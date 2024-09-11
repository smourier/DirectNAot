#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfsampleoutputstream
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("8feed468-6f7e-440d-869a-49bdd283ad0d")]
public partial interface IMFSampleOutputStream
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsampleoutputstream-beginwritesample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginWriteSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] IMFSample pSample, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsampleoutputstream-endwritesample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndWriteSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
