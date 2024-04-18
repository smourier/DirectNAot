namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_tex2dms_array_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_TEX2DMS_ARRAY_SRV
{
    public uint FirstArraySlice;
    public uint ArraySize;
}
