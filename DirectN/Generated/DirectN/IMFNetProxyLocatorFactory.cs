#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetproxylocatorfactory
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e9cd0384-a268-4bb4-82de-658d53574d41")]
public partial interface IMFNetProxyLocatorFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetproxylocatorfactory-createproxylocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateProxyLocator(PWSTR pszProtocol, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFNetProxyLocator>))] out IMFNetProxyLocator ppProxyLocator);
}
