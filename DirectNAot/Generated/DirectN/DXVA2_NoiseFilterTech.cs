#nullable enable
namespace DirectN;

public enum DXVA2_NoiseFilterTech
{
    DXVA2_NoiseFilterTech_Unsupported = 0,
    DXVA2_NoiseFilterTech_Unknown = 1,
    DXVA2_NoiseFilterTech_Median = 2,
    DXVA2_NoiseFilterTech_Temporal = 4,
    DXVA2_NoiseFilterTech_BlockNoise = 8,
    DXVA2_NoiseFilterTech_MosquitoNoise = 16,
    DXVA2_NoiseFilterTech_Mask = 31,
}
