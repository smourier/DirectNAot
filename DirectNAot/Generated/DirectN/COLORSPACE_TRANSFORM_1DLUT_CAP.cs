namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct COLORSPACE_TRANSFORM_1DLUT_CAP
{
    public uint NumberOfLUTEntries;
    public COLORSPACE_TRANSFORM_DATA_CAP DataCap;
}
