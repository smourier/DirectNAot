#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaenginenotify
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fee7c112-e776-42b5-9bbf-0048524e2bd5")]
public partial interface IMFMediaEngineNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginenotify-eventnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EventNotify(uint @event, nuint param1, uint param2);
}
