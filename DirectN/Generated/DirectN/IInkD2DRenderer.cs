#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/inkrenderer/nn-inkrenderer-iinkd2drenderer
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("407fb1de-f85a-4150-97cf-b7fb274fb4f8")]
public partial interface IInkD2DRenderer
{
    // https://learn.microsoft.com/windows/win32/api/inkrenderer/nf-inkrenderer-iinkd2drenderer-draw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Draw(nint pD2D1DeviceContext, nint pInkStrokeIterable, BOOL fHighContrast);
}
