#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-ddcompbufferinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDCOMPBUFFERINFO
{
    public uint dwSize;
    public uint dwNumCompBuffers;
    public uint dwWidthToCreate;
    public uint dwHeightToCreate;
    public uint dwBytesToAllocate;
    public DDSCAPS2 ddCompCaps;
    public DDPIXELFORMAT ddPixelFormat;
}
