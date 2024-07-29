#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iacousticechocancellationcontrol
[GeneratedComInterface, Guid("f4ae25b5-aaa3-437d-b6b3-dbbe2d0e9549")]
public partial interface IAcousticEchoCancellationControl
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iacousticechocancellationcontrol-setechocancellationrenderendpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEchoCancellationRenderEndpoint(PWSTR endpointId);
}
