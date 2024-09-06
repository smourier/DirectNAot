#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsourcereaderex
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("7b981cf0-560e-4116-9875-b099895f23d7")]
public partial interface IMFSourceReaderEx : IMFSourceReader
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereaderex-setnativemediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNativeMediaType(uint dwStreamIndex, IMFMediaType? pMediaType, out uint pdwStreamFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereaderex-addtransformforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTransformForStream(uint dwStreamIndex, nint pTransformOrActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereaderex-removealltransformsforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllTransformsForStream(uint dwStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereaderex-gettransformforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformForStream(uint dwStreamIndex, uint dwTransformIndex, nint /* optional Guid* */ pGuidCategory, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTransform>))] out IMFTransform ppTransform);
}
