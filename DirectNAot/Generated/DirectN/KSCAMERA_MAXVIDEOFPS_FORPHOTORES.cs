namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_MAXVIDEOFPS_FORPHOTORES
{
    public uint PhotoResWidth;
    public uint PhotoResHeight;
    public uint PreviewFPSNum;
    public uint PreviewFPSDenom;
    public uint CaptureFPSNum;
    public uint CaptureFPSDenom;
}
