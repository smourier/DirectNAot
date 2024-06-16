#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetcrossoriginsupport
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("bc2b7d44-a72d-49d5-8376-1480dee58b22")]
public partial interface IMFNetCrossOriginSupport
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcrossoriginsupport-getcrossoriginpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCrossOriginPolicy(out MF_CROSS_ORIGIN_POLICY pPolicy);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcrossoriginsupport-getsourceorigin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceOrigin(out PWSTR wszSourceOrigin);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSameOrigin(PWSTR wszURL, out BOOL pfIsSameOrigin);
}
