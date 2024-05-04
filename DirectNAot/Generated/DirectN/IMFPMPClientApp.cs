#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpmpclientapp
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c004f646-be2c-48f3-93a2-a0983eba1108")]
public partial interface IMFPMPClientApp
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpmpclientapp-setpmphost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPMPHost(IMFPMPHostApp pPMPHost);
}
