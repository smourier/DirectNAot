#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-devhtadjdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DEVHTADJDATA
{
    public uint DeviceFlags;
    public uint DeviceXDPI;
    public uint DeviceYDPI;
    public nint pDefHTInfo;
    public nint pAdjHTInfo;
}
