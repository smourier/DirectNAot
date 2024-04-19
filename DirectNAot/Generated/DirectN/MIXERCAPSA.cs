namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercapsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERCAPSA
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArrayFoundationCHAR32 szPname;
    public uint fdwSupport;
    public uint cDestinations;
}
