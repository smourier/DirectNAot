#nullable enable
namespace DirectN;

public partial struct D3D12_DEVICE_CONFIGURATION_DESC
{
    public D3D12_DEVICE_FLAGS Flags;
    public uint GpuBasedValidationFlags;
    public uint SDKVersion;
    public uint NumEnabledExperimentalFeatures;
}
