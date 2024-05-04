namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_pointer_shape_info
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_OUTDUPL_POINTER_SHAPE_INFO
{
    public uint Type;
    public uint Width;
    public uint Height;
    public uint Pitch;
    public POINT HotSpot;
}
