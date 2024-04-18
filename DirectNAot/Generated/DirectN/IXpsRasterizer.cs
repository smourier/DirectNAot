namespace DirectN;

[GeneratedComInterface, Guid("7567cfc8-c156-47a8-9dac-11a2ae5bdd6b")]
public partial interface IXpsRasterizer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RasterizeRect(int x, int y, int width, int height, IXpsRasterizerNotificationCallback notificationCallback, out IWICBitmap bitmap);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMinimalLineWidth(int width);
}
