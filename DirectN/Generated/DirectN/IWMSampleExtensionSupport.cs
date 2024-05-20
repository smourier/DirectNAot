#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmsampleextensionsupport
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9bca9884-0604-4c2a-87da-793ff4d586c3")]
public partial interface IWMSampleExtensionSupport
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmsampleextensionsupport-setusesampleextensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUseSampleExtensions([MarshalAs(UnmanagedType.U4)] bool fUseExtensions);
}
