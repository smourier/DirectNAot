namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_matrix
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_MATRIX
{
    public float m11;
    public float m12;
    public float m21;
    public float m22;
    public float dx;
    public float dy;
}
