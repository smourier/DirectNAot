#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9c16ce3e-10f5-41fd-9ddc-6826669c2ff6")]
public partial interface IXpsRasterizationFactory2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRasterizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage?>))] IXpsOMPage? xpsPage, float DPIX, float DPIY, XPSRAS_RENDERING_MODE nonTextRenderingMode, XPSRAS_RENDERING_MODE textRenderingMode, XPSRAS_PIXEL_FORMAT pixelFormat, XPSRAS_BACKGROUND_COLOR backgroundColor, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsRasterizer>))] out IXpsRasterizer ppIXpsRasterizer);
}
