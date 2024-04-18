namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrformat
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRFORMAT
{
    public uint dSignature;
    public uint nVersion;
    public uint cbData;
    public uint offData;
}
