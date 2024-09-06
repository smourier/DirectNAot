#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediacapture/nn-mfmediacapture-iadvancedmediacapture
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("d0751585-d216-4344-b5bf-463b68f977bb")]
public partial interface IAdvancedMediaCapture
{
    // https://learn.microsoft.com/windows/win32/api/mfmediacapture/nf-mfmediacapture-iadvancedmediacapture-getadvancedmediacapturesettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdvancedMediaCaptureSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAdvancedMediaCaptureSettings>))] out IAdvancedMediaCaptureSettings value);
}
