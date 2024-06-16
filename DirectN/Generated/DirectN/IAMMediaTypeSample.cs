#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amstream/nn-amstream-iammediatypesample
[GeneratedComInterface, Guid("ab6b4afb-f6e4-11d0-900d-00c04fd9189d")]
public partial interface IAMMediaTypeSample : IStreamSample
{
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-setpointer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPointer(nint /* byte array */ pBuffer, int lSize);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-getpointer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPointer(out nint /* byte array */ ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-getsize
    [PreserveSig]
    int GetSize();
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-gettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTime(out long pTimeStart, out long pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-settime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTime(in long pTimeStart, in long pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-issyncpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSyncPoint();
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-setsyncpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncPoint(BOOL bIsSyncPoint);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-ispreroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPreroll();
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-setpreroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPreroll(BOOL bIsPreroll);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-getactualdatalength
    [PreserveSig]
    int GetActualDataLength();
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-setactualdatalength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActualDataLength(int __MIDL__IAMMediaTypeSample0000);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-getmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaType(out nint ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-setmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaType(in AM_MEDIA_TYPE pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-isdiscontinuity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDiscontinuity();
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-setdiscontinuity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDiscontinuity(BOOL bDiscontinuity);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-getmediatime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTime(out long pTimeStart, out long pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediatypesample-setmediatime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaTime(in long pTimeStart, in long pTimeEnd);
}
