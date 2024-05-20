#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmproximitydetection
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("6a9fd8ee-b651-4bf0-b849-7d4ece79a2b1")]
public partial interface IWMProximityDetection
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmproximitydetection-startdetection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartDetection(nint /* byte array */ pbRegistrationMsg, uint cbRegistrationMsg, nint /* byte array */ pbLocalAddress, uint cbLocalAddress, uint dwExtraPortsAllowed, out INSSBuffer ppRegistrationResponseMsg, IWMStatusCallback pCallback, nint pvContext);
}
