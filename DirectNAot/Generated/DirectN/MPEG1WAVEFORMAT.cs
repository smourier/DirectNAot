namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmreg/ns-mmreg-mpeg1waveformat
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG1WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort fwHeadLayer;
    public uint dwHeadBitrate;
    public ushort fwHeadMode;
    public ushort fwHeadModeExt;
    public ushort wHeadEmphasis;
    public ushort fwHeadFlags;
    public uint dwPTSLow;
    public uint dwPTSHigh;
}
