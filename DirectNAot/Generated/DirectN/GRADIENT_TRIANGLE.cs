namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-gradient_triangle
[StructLayout(LayoutKind.Sequential)]
public partial struct GRADIENT_TRIANGLE
{
    public uint Vertex1;
    public uint Vertex2;
    public uint Vertex3;
}
