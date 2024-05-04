#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/ne-encdec-prottype
public enum ProtType
{
    PROT_COPY_FREE = 1,
    PROT_COPY_ONCE = 2,
    PROT_COPY_NEVER = 3,
    PROT_COPY_NEVER_REALLY = 4,
    PROT_COPY_NO_MORE = 5,
    PROT_COPY_FREE_CIT = 6,
    PROT_COPY_BF = 7,
    PROT_COPY_CN_RECORDING_STOP = 8,
    PROT_COPY_FREE_SECURE = 9,
    PROT_COPY_INVALID = 50,
}
