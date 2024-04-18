namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_counter_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_COUNTER_DESC
{
    public D3D10_COUNTER Counter;
    public uint MiscFlags;
}
