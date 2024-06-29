#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersource
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("eb0c8cf9-6950-4772-87b1-47d11cf3a02f")]
public partial interface IMSVidStreamBufferSource : IMSVidFilePlayback
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource-get_start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Start(out int lStart);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource-get_recordingattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecordingAttribute(out nint pRecordingAttribute);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource-currentratings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CurrentRatings(out EnTvRat_System pEnSystem, out EnTvRat_GenericLevel pEnRating, out int pBfEnAttr);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource-maxratingslevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MaxRatingsLevel(EnTvRat_System enSystem, EnTvRat_GenericLevel enRating, int lbfEnAttr);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource-put_blockunrated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BlockUnrated(VARIANT_BOOL bBlock);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource-put_unrateddelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UnratedDelay(int dwDelay);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource-get_sbesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SBESource(out nint sbeFilter);
}
