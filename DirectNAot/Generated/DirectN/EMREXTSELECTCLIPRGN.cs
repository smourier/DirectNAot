namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrextselectcliprgn
[StructLayout(LayoutKind.Sequential)]
public partial struct EMREXTSELECTCLIPRGN
{
    public EMR emr;
    public uint cbRgnData;
    public uint iMode;
    public InlineArrayByte1 RgnData; // variable-length array placeholder
}
