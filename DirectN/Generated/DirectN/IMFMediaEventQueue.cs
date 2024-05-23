#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmediaeventqueue
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("36f846fc-2256-48b6-b58e-e2b638316581")]
public partial interface IMFMediaEventQueue
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventqueue-getevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvent(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEvent>))] out IMFMediaEvent ppEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventqueue-begingetevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginGetEvent(IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventqueue-endgetevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndGetEvent(IMFAsyncResult pResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEvent>))] out IMFMediaEvent ppEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventqueue-queueevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueEvent(IMFMediaEvent pEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventqueue-queueeventparamvar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueEventParamVar(uint met, in Guid guidExtendedType, HRESULT hrStatus, in PROPVARIANT pvValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventqueue-queueeventparamunk
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueEventParamUnk(uint met, in Guid guidExtendedType, HRESULT hrStatus, nint pUnk);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventqueue-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
