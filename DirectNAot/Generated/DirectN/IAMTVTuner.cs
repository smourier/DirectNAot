#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtvtuner
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("211a8766-03ac-11d1-8d13-00aa00bd8339")]
public partial interface IAMTVTuner : IAMTuner
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-get_availabletvformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvailableTVFormats(out int lAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-get_tvformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TVFormat(out int plAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-autotune
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AutoTune(int lChannel, out int plFoundSignal);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-storeautotune
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StoreAutoTune();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-get_numinputconnections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumInputConnections(out int plNumInputConnections);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-put_inputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InputType(int lIndex, TunerInputType InputType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-get_inputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputType(int lIndex, out TunerInputType pInputType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-put_connectinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ConnectInput(int lIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-get_connectinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ConnectInput(out int plIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-get_videofrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoFrequency(out int lFreq);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvtuner-get_audiofrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioFrequency(out int lFreq);
}
