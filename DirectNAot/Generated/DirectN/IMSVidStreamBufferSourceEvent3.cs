namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersourceevent3
[GeneratedComInterface, Guid("ceabd6ab-9b90-4570-adf1-3ce76e00a763")]
public partial interface IMSVidStreamBufferSourceEvent3 : IMSVidStreamBufferSourceEvent2
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent3-broadcastevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BroadcastEvent(BSTR Guid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent3-broadcasteventex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BroadcastEventEx(BSTR Guid, uint Param1, uint Param2, uint Param3, uint Param4);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent3-coppblocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT COPPBlocked();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent3-coppunblocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT COPPUnblocked();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent3-contentprimarilyaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContentPrimarilyAudio();
}
