#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9deinterlacecaps
public partial struct VMR9DeinterlaceCaps
{
    public uint dwSize;
    public uint dwNumPreviousOutputFrames;
    public uint dwNumForwardRefSamples;
    public uint dwNumBackwardRefSamples;
    public VMR9DeinterlaceTech DeinterlaceTechnology;
}
