#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/imfdxgidevicemanagersource
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("20bc074b-7a8d-4609-8c3b-64a0a3b5d7ce")]
public partial interface IMFDXGIDeviceManagerSource
{
    // https://learn.microsoft.com/windows/win32/medfound/imfdxgidevicemanagersource-getmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetManager(out IMFDXGIDeviceManager ppManager);
}
