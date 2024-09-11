#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediacapture/nn-mfmediacapture-iadvancedmediacaptureinitializationsettings
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3de21209-8ba6-4f2a-a577-2819b56ff14d")]
public partial interface IAdvancedMediaCaptureInitializationSettings
{
    // https://learn.microsoft.com/windows/win32/api/mfmediacapture/nf-mfmediacapture-iadvancedmediacaptureinitializationsettings-setdirectxdevicemanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectxDeviceManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFDXGIDeviceManager>))] IMFDXGIDeviceManager value);
}
