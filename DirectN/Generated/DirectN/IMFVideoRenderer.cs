#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfvideorenderer
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("dfdfd197-a9ca-43d8-b341-6af3503792cd")]
public partial interface IMFVideoRenderer
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideorenderer-initializerenderer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeRenderer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTransform?>))] IMFTransform? pVideoMixer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFVideoPresenter?>))] IMFVideoPresenter? pVideoPresenter);
}
