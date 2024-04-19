namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_videoprocessorcaps
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_VideoProcessorCaps
{
    public uint DeviceCaps;
    public D3DPOOL InputPool;
    public uint NumForwardRefSamples;
    public uint NumBackwardRefSamples;
    public uint Reserved;
    public uint DeinterlaceTechnology;
    public uint ProcAmpControlCaps;
    public uint VideoProcessorOperations;
    public uint NoiseFilterTechnology;
    public uint DetailFilterTechnology;
}
