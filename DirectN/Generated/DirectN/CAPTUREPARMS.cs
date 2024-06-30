#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-captureparms
public partial struct CAPTUREPARMS
{
    public uint dwRequestMicroSecPerFrame;
    public BOOL fMakeUserHitOKToCapture;
    public uint wPercentDropForError;
    public BOOL fYield;
    public uint dwIndexSize;
    public uint wChunkGranularity;
    public BOOL fUsingDOSMemory;
    public uint wNumVideoRequested;
    public BOOL fCaptureAudio;
    public uint wNumAudioRequested;
    public uint vKeyAbort;
    public BOOL fAbortLeftMouse;
    public BOOL fAbortRightMouse;
    public BOOL fLimitEnabled;
    public uint wTimeLimit;
    public BOOL fMCIControl;
    public BOOL fStepMCIDevice;
    public uint dwMCIStartTime;
    public uint dwMCIStopTime;
    public BOOL fStepCaptureAt2x;
    public uint wStepCaptureAverageFrames;
    public uint dwAudioBufferSize;
    public BOOL fDisableWriteCache;
    public uint AVStreamMaster;
}
