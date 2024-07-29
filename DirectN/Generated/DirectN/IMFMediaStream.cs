#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediastream
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d182108f-4ec6-443f-aa42-a71106ec825f")]
public partial interface IMFMediaStream : IMFMediaEventGenerator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediastream-getmediasource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] out IMFMediaSource ppMediaSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediastream-getstreamdescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamDescriptor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFStreamDescriptor>))] out IMFStreamDescriptor ppStreamDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediastream-requestsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestSample(nint pToken);
}
