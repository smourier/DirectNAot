#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_size
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_SIZE
{
    public float width;
    public float height;
}
