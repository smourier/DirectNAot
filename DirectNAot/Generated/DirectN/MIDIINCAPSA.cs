#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midiincapsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MIDIINCAPSA
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArrayFoundationCHAR_32 szPname;
    public uint dwSupport;
}
