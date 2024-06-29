#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-iactivateaudiointerfaceasyncoperation
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("72a22d78-cde4-431d-b8cc-843a71199b6d")]
public partial interface IActivateAudioInterfaceAsyncOperation
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iactivateaudiointerfaceasyncoperation-getactivateresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActivateResult(out HRESULT activateResult, out nint activatedInterface);
}
