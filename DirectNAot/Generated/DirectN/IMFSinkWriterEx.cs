namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsinkwriterex
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("588d72ab-5bc1-496a-8714-b70617141b25")]
public partial interface IMFSinkWriterEx : IMFSinkWriter
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriterex-gettransformforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformForStream(uint dwStreamIndex, uint dwTransformIndex, nint /* optional Guid* */ pGuidCategory, out IMFTransform ppTransform);
}
