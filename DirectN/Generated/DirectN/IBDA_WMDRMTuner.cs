#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("86d979cf-a8a7-4f94-b5fb-14c0aca68fe6")]
public partial interface IBDA_WMDRMTuner
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PurchaseEntitlement(uint ulDialogRequest, BSTR bstrLanguage, uint ulPurchaseTokenLen, nint /* byte array */ pbPurchaseToken, out uint pulDescrambleStatus, ref uint pulCaptureTokenLen, nint /* byte array */ pbCaptureToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelCaptureToken(uint ulCaptureTokenLen, nint /* byte array */ pbCaptureToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPidProtection(uint ulPid, in Guid uuidKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPidProtection(uint pulPid, out Guid uuidKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncValue(uint ulSyncValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartCodeProfile(ref uint pulStartCodeProfileLen, nint /* byte array */ pbStartCodeProfile);
}
