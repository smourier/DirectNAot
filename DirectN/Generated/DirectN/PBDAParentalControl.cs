#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PBDAParentalControl
{
    public uint rating_system_count;
    public nint rating_systems;
}
