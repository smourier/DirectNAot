namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dcomposerectdestination
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DCOMPOSERECTDESTINATION
{
    public ushort SrcRectIndex;
    public ushort Reserved;
    public short X;
    public short Y;
}
