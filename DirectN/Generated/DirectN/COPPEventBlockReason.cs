#nullable enable
namespace DirectN;

public enum COPPEventBlockReason
{
    COPP_Unknown = -1,
    COPP_BadDriver = 0,
    COPP_NoCardHDCPSupport = 1,
    COPP_NoMonitorHDCPSupport = 2,
    COPP_BadCertificate = 3,
    COPP_InvalidBusProtection = 4,
    COPP_AeroGlassOff = 5,
    COPP_RogueApp = 6,
    COPP_ForbiddenVideo = 7,
    COPP_Activate = 8,
    COPP_DigitalAudioUnprotected = 9,
}
