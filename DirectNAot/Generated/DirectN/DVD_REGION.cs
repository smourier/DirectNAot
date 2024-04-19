namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-dvd_region
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_REGION
{
    public byte CopySystem;
    public byte RegionData;
    public byte SystemRegion;
    public byte ResetCount;
}
