namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcolormatchtotarget
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRCOLORMATCHTOTARGET
{
    public EMR emr;
    public uint dwAction;
    public uint dwFlags;
    public uint cbName;
    public uint cbData;
    public InlineArrayByte1 Data; // variable-length array placeholder
}
