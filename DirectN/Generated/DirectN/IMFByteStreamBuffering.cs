#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfbytestreambuffering
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6d66d782-1d4f-4db7-8c63-cb8c77f1ef5e")]
public partial interface IMFByteStreamBuffering
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreambuffering-setbufferingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferingParams(in MFBYTESTREAM_BUFFERING_PARAMS pParams);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreambuffering-enablebuffering
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableBuffering([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreambuffering-stopbuffering
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopBuffering();
}
