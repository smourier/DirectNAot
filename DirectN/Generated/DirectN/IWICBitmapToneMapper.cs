#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("44728ded-1edf-4fe9-b50b-c89a264c9439")]
public partial interface IWICBitmapToneMapper : IWICBitmapSource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeForHdrTarget([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pISource, in Guid guidDstFormat, float fLuminanceInNits, float fWhiteLevelInNits, WICBitmapToneMappingMode mode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeForSdrTarget([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pISource, in Guid guidDstFormat, WICBitmapToneMappingMode mode);
}
