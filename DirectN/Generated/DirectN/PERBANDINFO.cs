#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-perbandinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct PERBANDINFO
{
    public BOOL bRepeatThisBand;
    public SIZE szlBand;
    public uint ulHorzRes;
    public uint ulVertRes;
}
