namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrselectclippath
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSELECTCLIPPATH
{
    public EMR emr;
    public uint iMode;
}
