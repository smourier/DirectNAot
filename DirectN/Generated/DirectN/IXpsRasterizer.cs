#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7567cfc8-c156-47a8-9dac-11a2ae5bdd6b")]
public partial interface IXpsRasterizer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RasterizeRect(int x, int y, int width, int height, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsRasterizerNotificationCallback?>))] IXpsRasterizerNotificationCallback? notificationCallback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmap>))] out IWICBitmap bitmap);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMinimalLineWidth(int width);
}
