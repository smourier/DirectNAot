#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midiincapsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MIDIINCAPSW
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar_32 szPname;
    public uint dwSupport;
}
