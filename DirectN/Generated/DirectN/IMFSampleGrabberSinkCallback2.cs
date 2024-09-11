#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsamplegrabbersinkcallback2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ca86aa50-c46e-429e-ab27-16d6ac6844cb")]
public partial interface IMFSampleGrabberSinkCallback2 : IMFSampleGrabberSinkCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamplegrabbersinkcallback2-onprocesssampleex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnProcessSampleEx(in Guid guidMajorMediaType, uint dwSampleFlags, long llSampleTime, long llSampleDuration, nint /* byte array */ pSampleBuffer, uint dwSampleSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes);
}
