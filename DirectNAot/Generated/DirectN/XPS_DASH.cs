namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_dash
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_DASH
{
    public float length;
    public float gap;
}
