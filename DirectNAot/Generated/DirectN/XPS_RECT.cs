namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_rect
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_RECT
{
    public float x;
    public float y;
    public float width;
    public float height;
}
