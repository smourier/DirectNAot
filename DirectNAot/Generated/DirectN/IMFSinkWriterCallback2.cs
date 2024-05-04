#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsinkwritercallback2
[GeneratedComInterface, Guid("2456bd58-c067-4513-84fe-8d0c88ffdc61")]
public partial interface IMFSinkWriterCallback2 : IMFSinkWriterCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwritercallback2-ontransformchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTransformChange();
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwritercallback2-onstreamerror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStreamError(uint dwStreamIndex, HRESULT hrStatus);
}
