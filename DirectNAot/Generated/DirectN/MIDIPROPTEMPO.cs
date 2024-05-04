#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midiproptempo
[StructLayout(LayoutKind.Sequential)]
public partial struct MIDIPROPTEMPO
{
    public uint cbStruct;
    public uint dwTempo;
}
