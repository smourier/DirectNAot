#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WST_BUFFER
{
    public VBICODECFILTERING_SCANLINES ScanlinesRequested;
    public InlineArrayWST_BUFFER_LINE17 WstLines;
}
