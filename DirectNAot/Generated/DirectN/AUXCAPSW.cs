#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-auxcapsw
[StructLayout(LayoutKind.Sequential)]
public partial struct AUXCAPSW
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar32 szPname;
    public ushort wTechnology;
    public ushort wReserved1;
    public uint dwSupport;
}
