#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amstream/nn-amstream-iammediatypestream
[GeneratedComInterface, Guid("ab6b4afa-f6e4-11d0-900d-00c04fd9189d")]
public partial interface IAMMediaTypeStream : IMediaStream
{
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypestream-getformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(out AM_MEDIA_TYPE pMediaType, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypestream-setformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in AM_MEDIA_TYPE pMediaType, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypestream-createsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSample(int lSampleSize, nint /* byte array */ pbBuffer, uint dwFlags, nint pUnkOuter, out IAMMediaTypeSample ppAMMediaTypeSample);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypestream-getstreamallocatorrequirements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamAllocatorRequirements(out ALLOCATOR_PROPERTIES pProps);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypestream-setstreamallocatorrequirements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamAllocatorRequirements(in ALLOCATOR_PROPERTIES pProps);
}
