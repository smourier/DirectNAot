#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsamplegrabbersinkcallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8c7b80bf-ee42-4b59-b1df-55668e1bdca8")]
public partial interface IMFSampleGrabberSinkCallback : IMFClockStateSink
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamplegrabbersinkcallback-onsetpresentationclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSetPresentationClock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationClock>))] IMFPresentationClock pPresentationClock);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamplegrabbersinkcallback-onprocesssample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnProcessSample(in Guid guidMajorMediaType, uint dwSampleFlags, long llSampleTime, long llSampleDuration, nint /* byte array */ pSampleBuffer, uint dwSampleSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamplegrabbersinkcallback-onshutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnShutdown();
}
