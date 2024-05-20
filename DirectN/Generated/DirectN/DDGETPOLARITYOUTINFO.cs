#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetpolarityoutinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGETPOLARITYOUTINFO
{
    public uint bPolarity;
}
