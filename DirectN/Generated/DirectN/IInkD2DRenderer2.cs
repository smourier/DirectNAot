#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/inkrenderer/nn-inkrenderer-iinkd2drenderer2
[GeneratedComInterface, Guid("0a95dcd9-4578-4b71-b20b-bf664d4bfeee")]
public partial interface IInkD2DRenderer2
{
    // https://learn.microsoft.com/windows/win32/api/inkrenderer/nf-inkrenderer-iinkd2drenderer2-draw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Draw(nint pD2D1DeviceContext, nint pInkStrokeIterable, INK_HIGH_CONTRAST_ADJUSTMENT highContrastAdjustment);
}
