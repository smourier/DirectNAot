#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/ns-wmcodecdsp-aecqualitymetrics_struct
public partial struct AecQualityMetrics_Struct
{
    public long i64Timestamp;
    public byte ConvergenceFlag;
    public byte MicClippedFlag;
    public byte MicSilenceFlag;
    public byte PstvFeadbackFlag;
    public byte SpkClippedFlag;
    public byte SpkMuteFlag;
    public byte GlitchFlag;
    public byte DoubleTalkFlag;
    public uint uGlitchCount;
    public uint uMicClipCount;
    public float fDuration;
    public float fTSVariance;
    public float fTSDriftRate;
    public float fVoiceLevel;
    public float fNoiseLevel;
    public float fERLE;
    public float fAvgERLE;
    public uint dwReserved;
}
