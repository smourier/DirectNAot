namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmlicenserestore
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c70b6334-a22e-4efb-a245-15e65a004a13")]
public partial interface IWMLicenseRestore
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlicenserestore-restorelicenses
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreLicenses(uint dwFlags, IWMStatusCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlicenserestore-cancellicenserestore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelLicenseRestore();
}
