#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-waveincapsw
[StructLayout(LayoutKind.Sequential)]
public partial struct WAVEINCAPSW
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar32 szPname;
    public uint dwFormats;
    public ushort wChannels;
    public ushort wReserved1;
}
