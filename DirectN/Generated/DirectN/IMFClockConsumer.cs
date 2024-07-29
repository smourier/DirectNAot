#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfclockconsumer
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("6ef2a662-47c0-4666-b13d-cbb717f2fa2c")]
public partial interface IMFClockConsumer
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclockconsumer-setpresentationclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPresentationClock(IMFPresentationClock pPresentationClock);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclockconsumer-getpresentationclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresentationClock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationClock>))] out IMFPresentationClock ppPresentationClock);
}
