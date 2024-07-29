#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidaudiorendererevent2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("e3f55729-353b-4c43-a028-50f79aa9a907")]
public partial interface IMSVidAudioRendererEvent2 : IMSVidAudioRendererEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avdecaudiodualmono
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVDecAudioDualMono();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avaudiosamplerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVAudioSampleRate();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avaudiochannelconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVAudioChannelConfig();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avaudiochannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVAudioChannelCount();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avdeccommonmeanbitrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVDecCommonMeanBitRate();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avddsurroundmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVDDSurroundMode();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avdeccommoninputformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVDecCommonInputFormat();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererevent2-avdeccommonoutputformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AVDecCommonOutputFormat();
}
