namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/ne-wmcodecdsp-aec_vad_mode
public enum AEC_VAD_MODE
{
    AEC_VAD_DISABLED = 0,
    AEC_VAD_NORMAL = 1,
    AEC_VAD_FOR_AGC = 2,
    AEC_VAD_FOR_SILENCE_SUPPRESSION = 3,
}
