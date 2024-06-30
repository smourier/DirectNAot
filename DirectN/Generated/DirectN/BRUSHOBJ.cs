#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-brushobj
public partial struct BRUSHOBJ
{
    public uint iSolidColor;
    public nint pvRbrush;
    public uint flColorType;
}
