#nullable enable
namespace DirectN;

[Flags]
public enum DXCoreHardwareTypeFilterFlags : uint
{
    None = 0,
    GPU = 1,
    ComputeAccelerator = 2,
    NPU = 4,
    MediaAccelerator = 8,
}
