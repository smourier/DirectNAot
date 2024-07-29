#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsinkwritercallback
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("666f76de-33d2-41b9-a458-29ed0a972c58")]
public partial interface IMFSinkWriterCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwritercallback-onfinalize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFinalize(HRESULT hrStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwritercallback-onmarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnMarker(uint dwStreamIndex, nint pvContext);
}
