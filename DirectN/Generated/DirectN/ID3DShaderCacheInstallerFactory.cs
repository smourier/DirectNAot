#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("09b2dfe4-840f-401a-804c-0dd8aadc9e9f")]
public partial interface ID3DShaderCacheInstallerFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstaller(ID3DShaderCacheInstallerClient pClient, in Guid riid, out nint /* void */ ppvInstaller);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateExplorer(nint pUnknown, in Guid riid, out nint /* void */ ppvExplorer);
}
