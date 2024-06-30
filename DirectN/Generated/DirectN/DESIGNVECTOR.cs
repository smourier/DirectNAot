#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-designvector
public partial struct DESIGNVECTOR
{
    public uint dvReserved;
    public uint dvNumAxes;
    public InlineArrayInt32_16 dvValues;
}
