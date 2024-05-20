#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambufferrecordingcontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("160621aa-bbbc-4326-a824-c395aebc6e74")]
public partial interface IMSVidStreamBufferRecordingControl : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-get_starttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StartTime(out int rtStart);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-put_starttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StartTime(int rtStart);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-get_stoptime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StopTime(out int rtStop);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-put_stoptime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StopTime(int rtStop);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-get_recordingstopped
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecordingStopped(out VARIANT_BOOL phResult);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-get_recordingstarted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecordingStarted(out VARIANT_BOOL phResult);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-get_recordingtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecordingType(out RecordingType dwType);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferrecordingcontrol-get_recordingattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecordingAttribute(out nint pRecordingAttribute);
}
