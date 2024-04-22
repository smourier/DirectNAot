namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ColorMap
{
    public GdiPlusColor oldColor;
    public GdiPlusColor newColor;
}
