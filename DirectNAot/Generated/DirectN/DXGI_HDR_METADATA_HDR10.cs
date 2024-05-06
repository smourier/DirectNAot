#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_5/ns-dxgi1_5-dxgi_hdr_metadata_hdr10
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_HDR_METADATA_HDR10
{
    public InlineArrayUInt16_2 RedPrimary;
    public InlineArrayUInt16_2 GreenPrimary;
    public InlineArrayUInt16_2 BluePrimary;
    public InlineArrayUInt16_2 WhitePoint;
    public uint MaxMasteringLuminance;
    public uint MinMasteringLuminance;
    public ushort MaxContentLightLevel;
    public ushort MaxFrameAverageLightLevel;
}
