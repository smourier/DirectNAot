#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamaudioinputmixer
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("54c39221-8380-11d0-b3f0-00aa003761c5")]
public partial interface IAMAudioInputMixer
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-put_enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Enable([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Enable([MarshalAs(UnmanagedType.U4)] out bool pfEnable);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-put_mono
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Mono([MarshalAs(UnmanagedType.U4)] bool fMono);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_mono
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Mono([MarshalAs(UnmanagedType.U4)] out bool pfMono);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-put_mixlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MixLevel(double Level);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_mixlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MixLevel(out double pLevel);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-put_pan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Pan(double Pan);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_pan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Pan(out double pPan);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-put_loudness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Loudness([MarshalAs(UnmanagedType.U4)] bool fLoudness);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_loudness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Loudness([MarshalAs(UnmanagedType.U4)] out bool pfLoudness);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-put_treble
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Treble(double Treble);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_treble
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Treble(out double pTreble);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_treblerange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TrebleRange(out double pRange);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-put_bass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Bass(double Bass);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_bass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bass(out double pBass);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudioinputmixer-get_bassrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BassRange(out double pRange);
}
