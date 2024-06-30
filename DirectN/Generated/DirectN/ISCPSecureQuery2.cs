#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecurequery2
[GeneratedComInterface, Guid("ebe17e25-4fd7-4632-af46-6d93d4fcc72e")]
public partial interface ISCPSecureQuery2 : ISCPSecureQuery
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecurequery2-makedecision2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeDecision2(uint fuFlags, nint /* byte array */ pData, uint dwSize, uint dwAppSec, nint /* byte array */ pbSPSessionKey, uint dwSessionKeyLen, IMDSPStorageGlobals? pStorageGlobals, nint /* byte array */ pAppCertApp, uint dwAppCertAppLen, nint /* byte array */ pAppCertSP, uint dwAppCertSPLen, [MarshalUsing(CountElementName = nameof(pdwRevocationURLLen))] ref PWSTR[] pszRevocationURL, ref uint pdwRevocationURLLen, out uint pdwRevocationBitFlag, nint /* optional ulong* */ pqwFileSize, nint pUnknown, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISCPSecureExchange>))] out ISCPSecureExchange ppExchange, nint /* byte array */ abMac);
}
