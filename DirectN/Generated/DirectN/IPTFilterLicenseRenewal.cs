#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("26d836a5-0c15-44c7-ac59-b0da8728f240")]
public partial interface IPTFilterLicenseRenewal
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenewLicenses(PWSTR wszFileName, PWSTR wszExpiredKid, uint dwCallersId, BOOL bHighPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelLicenseRenewal();
}
