namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SONARCWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wCompType;
}
