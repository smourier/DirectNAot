namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mileffects/ns-mileffects-milmatrix3x2d
[StructLayout(LayoutKind.Sequential)]
public partial struct MilMatrix3x2D
{
    public double S_11;
    public double S_12;
    public double S_21;
    public double S_22;
    public double DX;
    public double DY;
}
