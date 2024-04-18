namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-axeslista
[StructLayout(LayoutKind.Sequential)]
public partial struct AXESLISTA
{
    public uint axlReserved;
    public uint axlNumAxes;
    public InlineArrayAXISINFOA16 axlAxisInfo;
}
