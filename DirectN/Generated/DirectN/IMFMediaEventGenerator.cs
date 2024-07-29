#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmediaeventgenerator
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2cd0bd52-bcd5-4b89-b62c-eadc0c031e7d")]
public partial interface IMFMediaEventGenerator
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventgenerator-getevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvent(MEDIA_EVENT_GENERATOR_GET_EVENT_FLAGS dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEvent>))] out IMFMediaEvent ppEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventgenerator-begingetevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginGetEvent(IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventgenerator-endgetevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndGetEvent(IMFAsyncResult pResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEvent>))] out IMFMediaEvent ppEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediaeventgenerator-queueevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueEvent(uint met, in Guid guidExtendedType, HRESULT hrStatus, in PROPVARIANT pvValue);
}
