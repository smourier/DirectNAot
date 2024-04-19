namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_procampvalues
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_ProcAmpValues
{
    public DXVA2_Fixed32 Brightness;
    public DXVA2_Fixed32 Contrast;
    public DXVA2_Fixed32 Hue;
    public DXVA2_Fixed32 Saturation;
}
