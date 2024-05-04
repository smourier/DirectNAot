#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d3eef34c-0667-4afc-8d13-867607b0fe91")]
public partial interface ICompositorInterop2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCompositionTextureSupport(nint renderingDevice, [MarshalAs(UnmanagedType.U4)] out bool supportsCompositionTextures);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompositionTexture(nint d3dTexture, out nint compositionTexture);
}
