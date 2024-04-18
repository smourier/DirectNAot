namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetmapperflags
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETMAPPERFLAGS
{
    public EMR emr;
    public uint dwFlags;
}
