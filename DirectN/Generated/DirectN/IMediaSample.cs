#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imediasample
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a8689a-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaSample
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-getpointer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPointer(out nint /* byte array */ ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-getsize
    [PreserveSig]
    int GetSize();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-gettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTime(out long pTimeStart, out long pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-settime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTime(nint /* optional long* */ pTimeStart, nint /* optional long* */ pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-issyncpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSyncPoint();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-setsyncpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncPoint(BOOL bIsSyncPoint);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-ispreroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPreroll();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-setpreroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPreroll(BOOL bIsPreroll);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-getactualdatalength
    [PreserveSig]
    int GetActualDataLength();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-setactualdatalength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActualDataLength(int __MIDL__IMediaSample0000);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-getmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaType(out nint ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-setmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaType(in AM_MEDIA_TYPE pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-isdiscontinuity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDiscontinuity();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-setdiscontinuity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDiscontinuity(BOOL bDiscontinuity);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-getmediatime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTime(out long pTimeStart, out long pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample-setmediatime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaTime(nint /* optional long* */ pTimeStart, nint /* optional long* */ pTimeEnd);
}
