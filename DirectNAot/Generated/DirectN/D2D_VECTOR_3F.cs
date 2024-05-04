#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_vector_3f
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_VECTOR_3F
{
    public float x;
    public float y;
    public float z;
}
