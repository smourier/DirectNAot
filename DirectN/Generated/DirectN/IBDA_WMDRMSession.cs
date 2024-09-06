#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4be6fa3d-07cd-4139-8b80-8c18ba3aec88")]
public partial interface IBDA_WMDRMSession
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint MaxCaptureToken, out uint MaxStreamingPid, out uint MaxLicense, out uint MinSecurityLevel, out uint RevInfoSequenceNumber, out ulong RevInfoIssuedTime, out uint RevInfoTTL, out uint RevListVersion, out uint ulState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRevInfo(uint ulRevInfoLen, nint /* byte array */ pbRevInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCrl(uint ulCrlLen, nint /* byte array */ pbCrlLen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransactMessage(uint ulcbRequest, nint /* byte array */ pbRequest, ref uint pulcbResponse, nint /* byte array */ pbResponse);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLicense(in Guid uuidKey, ref uint pulPackageLen, nint /* byte array */ pbPackage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReissueLicense(in Guid uuidKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenewLicense(uint ulInXmrLicenseLen, nint /* byte array */ pbInXmrLicense, uint ulEntitlementTokenLen, nint /* byte array */ pbEntitlementToken, out uint pulDescrambleStatus, ref uint pulOutXmrLicenseLen, nint /* byte array */ pbOutXmrLicense);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeyInfo(ref uint pulKeyInfoLen, nint /* byte array */ pbKeyInfo);
}
