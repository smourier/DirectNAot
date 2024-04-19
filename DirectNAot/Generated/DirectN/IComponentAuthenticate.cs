namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-icomponentauthenticate
[GeneratedComInterface, Guid("a9889c00-6d2b-11d3-8496-00c04f79dbc0")]
public partial interface IComponentAuthenticate
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-icomponentauthenticate-sacauth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SACAuth(uint dwProtocolID, uint dwPass, nint /* byte array */ pbDataIn, uint dwDataInLen, out nint /* byte array */ ppbDataOut, out uint pdwDataOutLen);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-icomponentauthenticate-sacgetprotocols
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SACGetProtocols(out uint ppdwProtocols, out uint pdwProtocolCount);
}
