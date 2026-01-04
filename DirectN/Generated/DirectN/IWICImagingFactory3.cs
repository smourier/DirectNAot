#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("489b3d8b-624a-4258-b678-7eece70f299d")]
public partial interface IWICImagingFactory3 : IWICImagingFactory2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapToneMapper([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapToneMapper>))] out IWICBitmapToneMapper ppToneMapper);
}
