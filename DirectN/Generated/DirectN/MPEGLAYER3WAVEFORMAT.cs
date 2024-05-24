#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmreg/ns-mmreg-mpeglayer3waveformat
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEGLAYER3WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wID;
    public MPEGLAYER3WAVEFORMAT_FLAGS fdwFlags;
    public ushort nBlockSize;
    public ushort nFramesPerBlock;
    public ushort nCodecDelay;
}
