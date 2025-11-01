#nullable enable
namespace DirectN;

[Flags]
public enum DXCoreRuntimeFilterFlags : uint
{
    None = 0,
    D3D11 = 1,
    D3D12 = 2,
}
