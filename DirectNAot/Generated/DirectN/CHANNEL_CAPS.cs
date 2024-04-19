namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CHANNEL_CAPS
{
    public uint dwFlags;
    public uint dwSrcRectXMod;
    public uint dwSrcRectYMod;
    public uint dwSrcRectWidthMod;
    public uint dwSrcRectHeightMod;
    public uint dwDstRectXMod;
    public uint dwDstRectYMod;
    public uint dwDstRectWidthMod;
    public uint dwDstRectHeightMod;
}
