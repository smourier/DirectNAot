#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-ietfilterconfig
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c4c4c4d1-0049-4e2b-98fb-9537f6ce516d")]
public partial interface IETFilterConfig
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ietfilterconfig-initlicense
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitLicense(int LicenseId);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ietfilterconfig-getsecurechannelobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecureChannelObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnkDRMSecureChannel);
}
