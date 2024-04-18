namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_point
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_POINT
{
    public float x;
    public float y;
}
