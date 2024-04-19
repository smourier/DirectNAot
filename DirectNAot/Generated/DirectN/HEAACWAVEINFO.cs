namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmreg/ns-mmreg-heaacwaveinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct HEAACWAVEINFO
{
    public WAVEFORMATEX wfx;
    public ushort wPayloadType;
    public ushort wAudioProfileLevelIndication;
    public ushort wStructType;
    public ushort wReserved1;
    public uint dwReserved2;
}
