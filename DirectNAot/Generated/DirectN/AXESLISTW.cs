namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-axeslistw
[StructLayout(LayoutKind.Sequential)]
public partial struct AXESLISTW
{
    public uint axlReserved;
    public uint axlNumAxes;
    public InlineArrayAXISINFOW16 axlAxisInfo;
}
