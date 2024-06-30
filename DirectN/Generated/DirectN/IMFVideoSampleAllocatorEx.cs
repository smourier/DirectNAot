#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideosampleallocatorex
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("545b3a48-3283-4f62-866f-a62d8f598f9f")]
public partial interface IMFVideoSampleAllocatorEx : IMFVideoSampleAllocator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocatorex-initializesampleallocatorex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeSampleAllocatorEx(uint cInitialSamples, uint cMaximumSamples, IMFAttributes? pAttributes, IMFMediaType pMediaType);
}
