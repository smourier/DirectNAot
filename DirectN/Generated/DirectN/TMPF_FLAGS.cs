#nullable enable
namespace DirectN;

[Flags]
public enum TMPF_FLAGS : byte
{
    TMPF_FIXED_PITCH = 1,
    TMPF_VECTOR = 2,
    TMPF_DEVICE = 8,
    TMPF_TRUETYPE = 4,
}
