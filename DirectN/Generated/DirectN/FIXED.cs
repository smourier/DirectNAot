#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-fixed
public partial struct FIXED
{
    public ushort fract;
    public short value;
}
