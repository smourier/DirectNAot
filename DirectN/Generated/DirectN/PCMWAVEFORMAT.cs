#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-pcmwaveformat
[StructLayout(LayoutKind.Sequential)]
public partial struct PCMWAVEFORMAT
{
    public WAVEFORMAT wf;
    public ushort wBitsPerSample;
}
