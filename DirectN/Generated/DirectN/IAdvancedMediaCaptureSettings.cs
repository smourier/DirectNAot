#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediacapture/nn-mfmediacapture-iadvancedmediacapturesettings
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("24e0485f-a33e-4aa1-b564-6019b1d14f65")]
public partial interface IAdvancedMediaCaptureSettings
{
    // https://learn.microsoft.com/windows/win32/api/mfmediacapture/nf-mfmediacapture-iadvancedmediacapturesettings-getdirectxdevicemanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirectxDeviceManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFDXGIDeviceManager>))] out IMFDXGIDeviceManager value);
}
