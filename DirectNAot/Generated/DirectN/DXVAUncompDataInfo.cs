namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxvauncompdatainfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAUncompDataInfo
{
    public uint UncompWidth;
    public uint UncompHeight;
    public D3DFORMAT UncompFormat;
}
