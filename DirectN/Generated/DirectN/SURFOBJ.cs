#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-surfobj
[StructLayout(LayoutKind.Sequential)]
public partial struct SURFOBJ
{
    public DHSURF dhsurf;
    public HSURF hsurf;
    public DHPDEV dhpdev;
    public HDEV hdev;
    public SIZE sizlBitmap;
    public uint cjBits;
    public nint pvBits;
    public nint pvScan0;
    public int lDelta;
    public uint iUniq;
    public uint iBitmapFormat;
    public ushort iType;
    public ushort fjBitmap;
}
