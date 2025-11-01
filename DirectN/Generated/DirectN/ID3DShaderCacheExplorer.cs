#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("90432322-32f5-487f-9264-e9390fa58b2a")]
public partial interface ID3DShaderCacheExplorer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationFromExePath(PWSTR pFullExePath, in Guid riid, out nint /* void */ ppvApp);
}
