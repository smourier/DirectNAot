namespace DirectN;

public enum DXVA_SampleFlags
{
    DXVA_SampleFlagsMask = 15,
    DXVA_SampleFlag_Palette_Changed = 1,
    DXVA_SampleFlag_SrcRect_Changed = 2,
    DXVA_SampleFlag_DstRect_Changed = 4,
    DXVA_SampleFlag_ColorData_Changed = 8,
}
