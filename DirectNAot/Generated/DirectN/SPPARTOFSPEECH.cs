#nullable enable
namespace DirectN;

public enum SPPARTOFSPEECH
{
    SPPS_NotOverriden = -1,
    SPPS_Unknown = 0,
    SPPS_Noun = 4096,
    SPPS_Verb = 8192,
    SPPS_Modifier = 12288,
    SPPS_Function = 16384,
    SPPS_Interjection = 20480,
    SPPS_Noncontent = 24576,
    SPPS_LMA = 28672,
    SPPS_SuppressWord = 61440,
}
