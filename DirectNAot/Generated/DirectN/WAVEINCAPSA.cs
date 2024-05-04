#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-waveincapsa
[StructLayout(LayoutKind.Sequential)]
public partial struct WAVEINCAPSA
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArrayFoundationCHAR32 szPname;
    public uint dwFormats;
    public ushort wChannels;
    public ushort wReserved1;
}
