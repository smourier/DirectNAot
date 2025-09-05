#nullable enable
namespace DirectN;

[Flags]
public enum ACCEL_VIRT_FLAGS : byte
{
    FVIRTKEY = 1,
    FNOINVERT = 2,
    FSHIFT = 4,
    FCONTROL = 8,
    FALT = 16,
}
