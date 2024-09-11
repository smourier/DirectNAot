#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideosampleallocator
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("86cbc910-e533-4751-8e3b-f19b5b806a03")]
public partial interface IMFVideoSampleAllocator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocator-setdirectxmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectXManager(nint pManager);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocator-uninitializesampleallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UninitializeSampleAllocator();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocator-initializesampleallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeSampleAllocator(uint cRequestedFrames, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocator-allocatesample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] out IMFSample ppSample);
}
