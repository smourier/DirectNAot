#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nn-spatialaudioclient-ispatialaudioclient
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("bbf8e066-aaaa-49be-9a4d-fd2a858ea27f")]
public partial interface ISpatialAudioClient
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-getstaticobjectposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStaticObjectPosition(AudioObjectType type, out float x, out float y, out float z);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-getnativestaticobjecttypemask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeStaticObjectTypeMask(out AudioObjectType mask);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-getmaxdynamicobjectcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxDynamicObjectCount(out uint value);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-getsupportedaudioobjectformatenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedAudioObjectFormatEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioFormatEnumerator>))] out IAudioFormatEnumerator enumerator);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-getmaxframecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxFrameCount(in WAVEFORMATEX objectFormat, out uint frameCountPerBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-isaudioobjectformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAudioObjectFormatSupported(in WAVEFORMATEX objectFormat);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-isspatialaudiostreamavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSpatialAudioStreamAvailable(in Guid streamUuid, nint /* optional PROPVARIANT* */ auxiliaryInfo);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient-activatespatialaudiostream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateSpatialAudioStream(in PROPVARIANT activationParams, in Guid riid, out nint /* void */ stream);
}
