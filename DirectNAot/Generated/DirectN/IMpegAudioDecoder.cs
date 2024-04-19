namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpegtype/nn-mpegtype-impegaudiodecoder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b45dd570-3c77-11d1-abe1-00a0c905f375")]
public partial interface IMpegAudioDecoder
{
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-get_frequencydivider
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrequencyDivider(out uint pDivider);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-put_frequencydivider
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FrequencyDivider(uint Divider);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-get_decoderaccuracy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DecoderAccuracy(out uint pAccuracy);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-put_decoderaccuracy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DecoderAccuracy(uint Accuracy);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-get_stereo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Stereo(out uint pStereo);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-put_stereo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Stereo(uint Stereo);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-get_decoderwordsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DecoderWordSize(out uint pWordSize);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-put_decoderwordsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DecoderWordSize(uint WordSize);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-get_integerdecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IntegerDecode(out uint pIntDecode);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-put_integerdecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IntegerDecode(uint IntDecode);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-get_dualmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DualMode(ref uint pIntDecode);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-put_dualmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DualMode(uint IntDecode);
    
    // https://learn.microsoft.com/windows/win32/api/mpegtype/nf-mpegtype-impegaudiodecoder-get_audioformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioFormat(out MPEG1WAVEFORMAT lpFmt);
}
