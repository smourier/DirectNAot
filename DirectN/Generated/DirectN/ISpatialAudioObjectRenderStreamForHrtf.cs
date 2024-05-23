#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nn-spatialaudiohrtf-ispatialaudioobjectrenderstreamforhrtf
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("e08deef9-5363-406e-9fdc-080ee247bbe0")]
public partial interface ISpatialAudioObjectRenderStreamForHrtf : ISpatialAudioObjectRenderStreamBase
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/nf-spatialaudiohrtf-ispatialaudioobjectrenderstreamforhrtf-activatespatialaudioobjectforhrtf
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioObjectForHrtf(AudioObjectType type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpatialAudioObjectForHrtf>))] out ISpatialAudioObjectForHrtf audioObject);
}
