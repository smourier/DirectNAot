#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-waveoutcapsw
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEOUTCAPSW
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar_32 szPname;
    public uint dwFormats;
    public ushort wChannels;
    public ushort wReserved1;
    public uint dwSupport;
}
