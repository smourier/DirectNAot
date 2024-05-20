#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-yxycolor
[StructLayout(LayoutKind.Sequential)]
public partial struct YxyCOLOR
{
    public ushort Y;
    public ushort x;
    public ushort y;
}
