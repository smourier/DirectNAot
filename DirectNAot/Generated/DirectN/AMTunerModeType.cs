namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-amtunermodetype
public enum AMTunerModeType
{
    AMTUNER_MODE_DEFAULT = 0,
    AMTUNER_MODE_TV = 1,
    AMTUNER_MODE_FM_RADIO = 2,
    AMTUNER_MODE_AM_RADIO = 4,
    AMTUNER_MODE_DSS = 8,
}
