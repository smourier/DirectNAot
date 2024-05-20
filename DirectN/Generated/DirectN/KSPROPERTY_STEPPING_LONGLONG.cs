#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_STEPPING_LONGLONG
{
    public ulong SteppingDelta;
    public KSPROPERTY_BOUNDS_LONGLONG Bounds;
}
