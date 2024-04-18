namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrseticmprofile
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETICMPROFILE
{
    public EMR emr;
    public uint dwFlags;
    public uint cbName;
    public uint cbData;
    public InlineArrayByte1 Data; // variable-length array placeholder
}
