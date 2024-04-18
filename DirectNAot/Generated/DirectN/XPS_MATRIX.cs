namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_matrix
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_MATRIX
{
    public float m11;
    public float m12;
    public float m21;
    public float m22;
    public float m31;
    public float m32;
}
