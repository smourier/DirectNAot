namespace DirectN;

public enum DXVA2_SampleFlags
{
    DXVA2_SampleFlag_Palette_Changed = 1,
    DXVA2_SampleFlag_SrcRect_Changed = 2,
    DXVA2_SampleFlag_DstRect_Changed = 4,
    DXVA2_SampleFlag_ColorData_Changed = 8,
    DXVA2_SampleFlag_PlanarAlpha_Changed = 16,
    DXVA2_SampleFlag_RFF = 65536,
    DXVA2_SampleFlag_TFF = 131072,
    DXVA2_SampleFlag_RFF_TFF_Present = 262144,
    DXVA2_SampleFlagsMask = -65505,
}
