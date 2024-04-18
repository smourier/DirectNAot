namespace DirectN;

[GeneratedComInterface, Guid("85fc5cca-2da6-494c-86b6-4a775c049b8a")]
public partial interface IDCompositionDevice4 : IDCompositionDevice3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckCompositionTextureSupport(nint renderingDevice, [MarshalAs(UnmanagedType.U4)] out bool supportsCompositionTextures);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateCompositionTexture(nint d3dTexture, out IDCompositionTexture compositionTexture);
}
