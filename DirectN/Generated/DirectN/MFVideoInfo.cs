#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfvideoinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct MFVideoInfo
{
    public uint dwWidth;
    public uint dwHeight;
    public MFRatio PixelAspectRatio;
    public MFVideoChromaSubsampling SourceChromaSubsampling;
    public MFVideoInterlaceMode InterlaceMode;
    public MFVideoTransferFunction TransferFunction;
    public MFVideoPrimaries ColorPrimaries;
    public MFVideoTransferMatrix TransferMatrix;
    public MFVideoLighting SourceLighting;
    public MFRatio FramesPerSecond;
    public MFNominalRange NominalRange;
    public MFVideoArea GeometricAperture;
    public MFVideoArea MinimumDisplayAperture;
    public MFVideoArea PanScanAperture;
    public ulong VideoFlags;
}
