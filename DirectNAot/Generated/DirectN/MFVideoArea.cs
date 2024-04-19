namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfvideoarea
[StructLayout(LayoutKind.Sequential)]
public partial struct MFVideoArea
{
    public MFOffset OffsetX;
    public MFOffset OffsetY;
    public FoundationSIZE Area;
}
