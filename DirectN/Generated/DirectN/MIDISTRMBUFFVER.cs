#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midistrmbuffver
[StructLayout(LayoutKind.Sequential)]
public partial struct MIDISTRMBUFFVER
{
    public uint dwVersion;
    public uint dwMid;
    public uint dwOEMVersion;
}
