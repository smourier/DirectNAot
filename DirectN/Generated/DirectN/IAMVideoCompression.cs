#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamvideocompression
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c6e13343-30ac-11d0-a18c-00a0c9118956")]
public partial interface IAMVideoCompression
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-put_keyframerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_KeyFrameRate(int KeyFrameRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-get_keyframerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeyFrameRate(out int pKeyFrameRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-put_pframesperkeyframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PFramesPerKeyFrame(int PFramesPerKeyFrame);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-get_pframesperkeyframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PFramesPerKeyFrame(out int pPFramesPerKeyFrame);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-put_quality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Quality(double Quality);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-get_quality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Quality(out double pQuality);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-put_windowsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WindowSize(ulong WindowSize);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-get_windowsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WindowSize(out ulong pWindowSize);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-getinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfo(PWSTR pszVersion, nint /* optional int* */ pcbVersion, PWSTR pszDescription, nint /* optional int* */ pcbDescription, nint /* optional int* */ pDefaultKeyFrameRate, nint /* optional int* */ pDefaultPFramesPerKey, nint /* optional double* */ pDefaultQuality, nint /* optional int* */ pCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-overridekeyframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverrideKeyFrame(int FrameNumber);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocompression-overrideframesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverrideFrameSize(int FrameNumber, int Size);
}
