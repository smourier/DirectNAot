#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaenginesupportssourcetransfer
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("a724b056-1b2e-4642-a6f3-db9420c52908")]
public partial interface IMFMediaEngineSupportsSourceTransfer
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesupportssourcetransfer-shouldtransfersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShouldTransferSource([MarshalAs(UnmanagedType.U4)] out bool pfShouldTransfer);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesupportssourcetransfer-detachmediasource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DetachMediaSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream ppByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] out IMFMediaSource ppMediaSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSourceExtension>))] out IMFMediaSourceExtension ppMSE);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesupportssourcetransfer-attachmediasource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AttachMediaSource(IMFByteStream? pByteStream, IMFMediaSource pMediaSource, IMFMediaSourceExtension? pMSE);
}
