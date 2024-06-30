#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrdeinterlacecaps
public partial struct VMRDeinterlaceCaps
{
    public uint dwSize;
    public uint dwNumPreviousOutputFrames;
    public uint dwNumForwardRefSamples;
    public uint dwNumBackwardRefSamples;
    public VMRDeinterlaceTech DeinterlaceTechnology;
}
