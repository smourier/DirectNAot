#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("85fc5cca-2da6-494c-86b6-4a775c049b8a")]
public partial interface IDCompositionDevice4 : IDCompositionDevice3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCompositionTextureSupport(nint renderingDevice, out BOOL supportsCompositionTextures);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompositionTexture(nint d3dTexture, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTexture>))] out IDCompositionTexture compositionTexture);
}
