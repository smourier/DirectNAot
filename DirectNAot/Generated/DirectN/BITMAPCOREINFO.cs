namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-bitmapcoreinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct BITMAPCOREINFO
{
    public BITMAPCOREHEADER bmciHeader;
    public InlineArrayRGBTRIPLE1 bmciColors; // variable-length array placeholder
}
