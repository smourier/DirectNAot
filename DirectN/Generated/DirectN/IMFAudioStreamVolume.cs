#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfaudiostreamvolume
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("76b1bbdb-4ec8-4f36-b106-70a9316df593")]
public partial interface IMFAudioStreamVolume
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiostreamvolume-getchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiostreamvolume-setchannelvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelVolume(uint dwIndex, float fLevel);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiostreamvolume-getchannelvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelVolume(uint dwIndex, out float pfLevel);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiostreamvolume-setallvolumes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllVolumes(uint dwCount, [In][MarshalUsing(CountElementName = nameof(dwCount))] float[] pfVolumes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfaudiostreamvolume-getallvolumes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllVolumes(uint dwCount, [In][Out][MarshalUsing(CountElementName = nameof(dwCount))] float[] pfVolumes);
}
