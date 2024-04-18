namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-dibsection
[StructLayout(LayoutKind.Sequential)]
public partial struct DIBSECTION
{
    public nint dsBm;
    public BITMAPINFOHEADER dsBmih;
    public InlineArrayUInt323 dsBitfields;
    public HANDLE dshSection;
    public uint dsOffset;
}
