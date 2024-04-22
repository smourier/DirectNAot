namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-logcolorspacea
[StructLayout(LayoutKind.Sequential)]
public partial struct LOGCOLORSPACEA
{
    public uint lcsSignature;
    public uint lcsVersion;
    public uint lcsSize;
    public LCSCSTYPE lcsCSType;
    public int lcsIntent;
    public CIEXYZTRIPLE lcsEndpoints;
    public uint lcsGammaRed;
    public uint lcsGammaGreen;
    public uint lcsGammaBlue;
    public InlineArrayFoundationCHAR260 lcsFilename;
}
