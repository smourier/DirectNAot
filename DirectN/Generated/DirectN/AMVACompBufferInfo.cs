#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvacompbufferinfo
public partial struct AMVACompBufferInfo
{
    public uint dwNumCompBuffers;
    public uint dwWidthToCreate;
    public uint dwHeightToCreate;
    public uint dwBytesToAllocate;
    public DDSCAPS2 ddCompCaps;
    public DDPIXELFORMAT ddPixelFormat;
}
