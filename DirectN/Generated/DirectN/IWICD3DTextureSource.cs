#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("caf65cc4-8ebe-4718-a21f-8dbf40bb7e25")]
public partial interface IWICD3DTextureSource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTexture(nint pD3DDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyBag2?>))] IPropertyBag2? pID3DTextureOptions, in Guid riid, out nint ppTexture);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformedTexture(nint /* optional WICRect* */ prc, uint uiWidth, uint uiHeight, nint /* optional Guid* */ pguidDstFormat, WICBitmapTransformOptions dstTransform, nint pD3DDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyBag2?>))] IPropertyBag2? pID3DTextureOptions, in Guid riid, out nint ppTexture);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportD3DDeviceType(in Guid riid, out BOOL pfIsSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetD3DTextureOptions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyBag2>))] out IPropertyBag2 ppID3DTextureOptions);
}
