namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecurequery
[GeneratedComInterface, Guid("1dcb3a0d-33ed-11d3-8470-00c04f79dbc0")]
public partial interface ISCPSecureQuery
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecurequery-getdatademands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataDemands(out uint pfuFlags, out uint pdwMinRightsData, out uint pdwMinExamineData, out uint pdwMinDecideData, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecurequery-examinedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExamineData(uint fuFlags, PWSTR pwszExtension, nint /* byte array */ pData, uint dwSize, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecurequery-makedecision
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeDecision(uint fuFlags, nint /* byte array */ pData, uint dwSize, uint dwAppSec, nint /* byte array */ pbSPSessionKey, uint dwSessionKeyLen, IMDSPStorageGlobals pStorageGlobals, out ISCPSecureExchange ppExchange, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecurequery-getrights
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRights(nint /* byte array */ pData, uint dwSize, nint /* byte array */ pbSPSessionKey, uint dwSessionKeyLen, IMDSPStorageGlobals pStgGlobals, out WMDMRIGHTS ppRights, out uint pnRightsCount, nint /* byte array */ abMac);
}
