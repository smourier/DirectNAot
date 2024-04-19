namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamdroppedframes
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c6e13344-30ac-11d0-a18c-00a0c9118956")]
public partial interface IAMDroppedFrames
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdroppedframes-getnumdropped
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumDropped(out int plDropped);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdroppedframes-getnumnotdropped
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumNotDropped(out int plNotDropped);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdroppedframes-getdroppedinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDroppedInfo(int lSize, out int plArray, out int plNumCopied);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdroppedframes-getaverageframesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAverageFrameSize(out int plAverageSize);
}
