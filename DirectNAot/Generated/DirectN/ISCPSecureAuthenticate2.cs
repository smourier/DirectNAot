namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecureauthenticate2
[GeneratedComInterface, Guid("b580cfae-1672-47e2-acaa-44bbecbcae5b")]
public partial interface ISCPSecureAuthenticate2 : ISCPSecureAuthenticate
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureauthenticate2-getscpsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSCPSession(out ISCPSession ppSCPSession);
}
