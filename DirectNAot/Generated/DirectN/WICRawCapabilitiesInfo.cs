namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicrawcapabilitiesinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct WICRawCapabilitiesInfo
{
    public uint cbSize;
    public uint CodecMajorVersion;
    public uint CodecMinorVersion;
    public WICRawCapabilities ExposureCompensationSupport;
    public WICRawCapabilities ContrastSupport;
    public WICRawCapabilities RGBWhitePointSupport;
    public WICRawCapabilities NamedWhitePointSupport;
    public uint NamedWhitePointSupportMask;
    public WICRawCapabilities KelvinWhitePointSupport;
    public WICRawCapabilities GammaSupport;
    public WICRawCapabilities TintSupport;
    public WICRawCapabilities SaturationSupport;
    public WICRawCapabilities SharpnessSupport;
    public WICRawCapabilities NoiseReductionSupport;
    public WICRawCapabilities DestinationColorProfileSupport;
    public WICRawCapabilities ToneCurveSupport;
    public WICRawRotationCapabilities RotationSupport;
    public WICRawCapabilities RenderModeSupport;
}
