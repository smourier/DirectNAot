namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_size_f
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_SIZE_F
{
    public float width;
    public float height;
}
