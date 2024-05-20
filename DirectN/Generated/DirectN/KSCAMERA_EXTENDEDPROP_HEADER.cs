#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_HEADER
{
    public uint Version;
    public uint PinId;
    public uint Size;
    public uint Result;
    public ulong Flags;
    public ulong Capability;
}
