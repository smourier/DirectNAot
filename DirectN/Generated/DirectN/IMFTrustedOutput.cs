#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftrustedoutput
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d19f8e95-b126-4446-890c-5dcb7ad71453")]
public partial interface IMFTrustedOutput
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftrustedoutput-getoutputtrustauthoritycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputTrustAuthorityCount(out uint pcOutputTrustAuthorities);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftrustedoutput-getoutputtrustauthoritybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputTrustAuthorityByIndex(uint dwIndex, out IMFOutputTrustAuthority ppauthority);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftrustedoutput-isfinal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsFinal([MarshalAs(UnmanagedType.U4)] out bool pfIsFinal);
}
