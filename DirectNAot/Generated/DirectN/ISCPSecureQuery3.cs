namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecurequery3
[GeneratedComInterface, Guid("b7edd1a2-4dab-484b-b3c5-ad39b8b4c0b1")]
public partial interface ISCPSecureQuery3 : ISCPSecureQuery2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecurequery3-getrightsonclearchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRightsOnClearChannel(nint /* byte array */ pData, uint dwSize, nint /* byte array */ pbSPSessionKey, uint dwSessionKeyLen, IMDSPStorageGlobals? pStgGlobals, IWMDMProgress3? pProgressCallback, out WMDMRIGHTS ppRights, out uint pnRightsCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecurequery3-makedecisiononclearchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeDecisionOnClearChannel(uint fuFlags, nint /* byte array */ pData, uint dwSize, uint dwAppSec, nint /* byte array */ pbSPSessionKey, uint dwSessionKeyLen, IMDSPStorageGlobals? pStorageGlobals, IWMDMProgress3? pProgressCallback, nint /* byte array */ pAppCertApp, uint dwAppCertAppLen, nint /* byte array */ pAppCertSP, uint dwAppCertSPLen, ref PWSTR pszRevocationURL, ref uint pdwRevocationURLLen, out uint pdwRevocationBitFlag, nint /* optional ulong */ pqwFileSize, nint pUnknown, out ISCPSecureExchange ppExchange);
}
