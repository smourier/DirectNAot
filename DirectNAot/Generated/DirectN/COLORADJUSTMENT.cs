namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-coloradjustment
[StructLayout(LayoutKind.Sequential)]
public partial struct COLORADJUSTMENT
{
    public ushort caSize;
    public ushort caFlags;
    public ushort caIlluminantIndex;
    public ushort caRedGamma;
    public ushort caGreenGamma;
    public ushort caBlueGamma;
    public ushort caReferenceBlack;
    public ushort caReferenceWhite;
    public short caContrast;
    public short caBrightness;
    public short caColorfulness;
    public short caRedGreenTint;
}
