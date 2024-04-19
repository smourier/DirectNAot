namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-captureparms
[StructLayout(LayoutKind.Sequential)]
public partial struct CAPTUREPARMS
{
    public uint dwRequestMicroSecPerFrame;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fMakeUserHitOKToCapture;
    public uint wPercentDropForError;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fYield;
    public uint dwIndexSize;
    public uint wChunkGranularity;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fUsingDOSMemory;
    public uint wNumVideoRequested;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fCaptureAudio;
    public uint wNumAudioRequested;
    public uint vKeyAbort;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fAbortLeftMouse;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fAbortRightMouse;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fLimitEnabled;
    public uint wTimeLimit;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fMCIControl;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fStepMCIDevice;
    public uint dwMCIStartTime;
    public uint dwMCIStopTime;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fStepCaptureAt2x;
    public uint wStepCaptureAverageFrames;
    public uint dwAudioBufferSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fDisableWriteCache;
    public uint AVStreamMaster;
}
