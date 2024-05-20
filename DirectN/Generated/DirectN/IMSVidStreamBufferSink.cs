#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersink
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("159dbb45-cd1b-4dab-83ea-5cb1f4f21d07")]
public partial interface IMSVidStreamBufferSink : IMSVidOutputDevice
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink-get_contentrecorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ContentRecorder(BSTR pszFilename, out IMSVidStreamBufferRecordingControl pRecordingIUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink-get_referencerecorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReferenceRecorder(BSTR pszFilename, out IMSVidStreamBufferRecordingControl pRecordingIUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink-get_sinkname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SinkName(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink-put_sinkname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SinkName(BSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink-namesetlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NameSetLock();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink-get_sbesink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SBESink(out nint sbeConfig);
}
