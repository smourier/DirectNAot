#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2c6bebfe-a603-472f-af34-d2443356e61b")]
public partial interface IDCompositionDevice5 : IDCompositionDevice4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDynamicTexture([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionDynamicTexture>))] out IDCompositionDynamicTexture compositionDynamicTexture);
}
