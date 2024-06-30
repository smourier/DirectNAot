#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideocapturesampleallocator
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("725b77c7-ca9f-4fe5-9d72-9946bf9b3c70")]
public partial interface IMFVideoCaptureSampleAllocator : IMFVideoSampleAllocator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideocapturesampleallocator-initializecapturesampleallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeCaptureSampleAllocator(uint cbSampleSize, uint cbCaptureMetadataSize, uint cbAlignment, uint cMinimumSamples, IMFAttributes? pAttributes, IMFMediaType pMediaType);
}
