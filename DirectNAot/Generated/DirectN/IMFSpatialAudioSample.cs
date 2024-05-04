#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nn-mfspatialaudio-imfspatialaudiosample
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("abf28a9b-3393-4290-ba79-5ffc46d986b2")]
public partial interface IMFSpatialAudioSample : IMFSample
{
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudiosample-getobjectcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectCount(out uint pdwObjectCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudiosample-addspatialaudioobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSpatialAudioObject(IMFSpatialAudioObjectBuffer pAudioObjBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfspatialaudio/nf-mfspatialaudio-imfspatialaudiosample-getspatialaudioobjectbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpatialAudioObjectByIndex(uint dwIndex, out IMFSpatialAudioObjectBuffer ppAudioObjBuffer);
}
