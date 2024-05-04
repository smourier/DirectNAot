#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8a78b317-e405-4a43-994a-620d8f5ce25e")]
public partial interface IDTFilterLicenseRenewal
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLicenseRenewalData(out PWSTR ppwszFileName, out PWSTR ppwszExpiredKid, out PWSTR ppwszTunerId);
}
