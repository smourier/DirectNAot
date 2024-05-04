#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSSTREAM_UVC_METADATA
{
    public KSSTREAM_UVC_METADATATYPE_TIMESTAMP StartOfFrameTimestamp;
    public KSSTREAM_UVC_METADATATYPE_TIMESTAMP EndOfFrameTimestamp;
}
