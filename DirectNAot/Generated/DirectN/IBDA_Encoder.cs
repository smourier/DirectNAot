namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_encoder
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3a8bad59-59fe-4559-a0ba-396cfaa98ae3")]
public partial interface IBDA_Encoder
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_encoder-querycapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryCapabilities(out uint NumAudioFmts, out uint NumVideoFmts);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_encoder-enumaudiocapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAudioCapability(uint FmtIndex, out uint MethodID, out uint AlgorithmType, out uint SamplingRate, out uint BitDepth, out uint NumChannels);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_encoder-enumvideocapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumVideoCapability(uint FmtIndex, out uint MethodID, out uint AlgorithmType, out uint VerticalSize, out uint HorizontalSize, out uint AspectRatio, out uint FrameRateCode, out uint ProgressiveSequence);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_encoder-setparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParameters(uint AudioBitrateMode, uint AudioBitrate, uint AudioMethodID, uint AudioProgram, uint VideoBitrateMode, uint VideoBitrate, uint VideoMethodID);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_encoder-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(out uint AudioBitrateMax, out uint AudioBitrateMin, out uint AudioBitrateMode, out uint AudioBitrateStepping, out uint AudioBitrate, out uint AudioMethodID, out uint AvailableAudioPrograms, out uint AudioProgram, out uint VideoBitrateMax, out uint VideoBitrateMin, out uint VideoBitrateMode, out uint VideoBitrate, out uint VideoBitrateStepping, out uint VideoMethodID, out uint SignalSourceID, out ulong SignalFormat, [MarshalAs(UnmanagedType.U4)] out bool SignalLock, out int SignalLevel, out uint SignalToNoiseRatio);
}
