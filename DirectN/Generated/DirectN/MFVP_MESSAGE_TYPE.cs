#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/ne-evr-mfvp_message_type
public enum MFVP_MESSAGE_TYPE
{
    MFVP_MESSAGE_FLUSH = 0,
    MFVP_MESSAGE_INVALIDATEMEDIATYPE = 1,
    MFVP_MESSAGE_PROCESSINPUTNOTIFY = 2,
    MFVP_MESSAGE_BEGINSTREAMING = 3,
    MFVP_MESSAGE_ENDSTREAMING = 4,
    MFVP_MESSAGE_ENDOFSTREAM = 5,
    MFVP_MESSAGE_STEP = 6,
    MFVP_MESSAGE_CANCELSTEP = 7,
}
