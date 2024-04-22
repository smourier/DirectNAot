namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_MODE_INFORMATION
{
    public uint Length;
    public uint ModeIndex;
    public uint VisScreenWidth;
    public uint VisScreenHeight;
    public uint ScreenStride;
    public uint NumberOfPlanes;
    public uint BitsPerPlane;
    public uint Frequency;
    public uint XMillimeter;
    public uint YMillimeter;
    public uint NumberRedBits;
    public uint NumberGreenBits;
    public uint NumberBlueBits;
    public uint RedMask;
    public uint GreenMask;
    public uint BlueMask;
    public uint AttributeFlags;
    public uint VideoMemoryBitmapWidth;
    public uint VideoMemoryBitmapHeight;
    public uint DriverSpecificAttributeFlags;
}
