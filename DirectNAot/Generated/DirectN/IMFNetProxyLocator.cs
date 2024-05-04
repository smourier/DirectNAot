#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetproxylocator
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e9cd0383-a268-4bb4-82de-658d53574d41")]
public partial interface IMFNetProxyLocator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetproxylocator-findfirstproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFirstProxy(PWSTR pszHost, PWSTR pszUrl, [MarshalAs(UnmanagedType.U4)] bool fReserved);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetproxylocator-findnextproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindNextProxy();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetproxylocator-registerproxyresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterProxyResult(HRESULT hrOp);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetproxylocator-getcurrentproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentProxy([MarshalUsing(CountElementName = nameof(pcchStr))] out PWSTR[] pszStr, ref uint pcchStr);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetproxylocator-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IMFNetProxyLocator ppProxyLocator);
}
