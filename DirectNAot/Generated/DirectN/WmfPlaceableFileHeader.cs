namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WmfPlaceableFileHeader
{
    public uint Key;
    public short Hmf;
    public PWMFRect16 BoundingBox;
    public short Inch;
    public uint Reserved;
    public short Checksum;
}
