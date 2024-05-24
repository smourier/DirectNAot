#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NABTS_BUFFER
{
    public VBICODECFILTERING_SCANLINES ScanlinesRequested;
    public long PictureNumber;
    public InlineArrayNABTS_BUFFER_LINE_11 NabtsLines;
}
