#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-auxcapsa
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AUXCAPSA
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArrayFoundationCHAR_32 szPname;
    public ushort wTechnology;
    public ushort wReserved1;
    public uint dwSupport;
}
