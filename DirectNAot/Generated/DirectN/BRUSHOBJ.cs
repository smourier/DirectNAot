namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-brushobj
[StructLayout(LayoutKind.Sequential)]
public partial struct BRUSHOBJ
{
    public uint iSolidColor;
    public nint pvRbrush;
    public uint flColorType;
}
