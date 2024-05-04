#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nn-spatialaudioclient-ispatialaudioobjectrenderstreamnotify
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("dddf83e6-68d7-4c70-883f-a1836afb4a50")]
public partial interface ISpatialAudioObjectRenderStreamNotify
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioobjectrenderstreamnotify-onavailabledynamicobjectcountchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnAvailableDynamicObjectCountChange(ISpatialAudioObjectRenderStreamBase sender, long hnsComplianceDeadlineTime, uint availableDynamicObjectCountChange);
}
