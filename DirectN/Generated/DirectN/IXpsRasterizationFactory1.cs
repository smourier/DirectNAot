#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2d6e5f77-6414-4a1e-a8e0-d4194ce6a26f")]
public partial interface IXpsRasterizationFactory1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRasterizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage?>))] IXpsOMPage? xpsPage, float DPI, XPSRAS_RENDERING_MODE nonTextRenderingMode, XPSRAS_RENDERING_MODE textRenderingMode, XPSRAS_PIXEL_FORMAT pixelFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsRasterizer>))] out IXpsRasterizer ppIXPSRasterizer);
}
