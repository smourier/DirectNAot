namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_size_u
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_SIZE_U
{
    public uint width;
    public uint height;
}
