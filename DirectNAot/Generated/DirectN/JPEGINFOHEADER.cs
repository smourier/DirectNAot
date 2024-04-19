namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct JPEGINFOHEADER
{
    public uint JPEGSize;
    public uint JPEGProcess;
    public uint JPEGColorSpaceID;
    public uint JPEGBitsPerSample;
    public uint JPEGHSubSampling;
    public uint JPEGVSubSampling;
}
