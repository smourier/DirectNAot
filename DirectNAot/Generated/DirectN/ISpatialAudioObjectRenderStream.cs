namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nn-spatialaudioclient-ispatialaudioobjectrenderstream
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("bab5f473-b423-477b-85f5-b5a332a04153")]
public partial interface ISpatialAudioObjectRenderStream : ISpatialAudioObjectRenderStreamBase
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioobjectrenderstream-activatespatialaudioobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioObject(AudioObjectType type, out ISpatialAudioObject audioObject);
}
