#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-palobj
[StructLayout(LayoutKind.Sequential)]
public partial struct PALOBJ
{
    public uint ulReserved;
}
