namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-designvector
[StructLayout(LayoutKind.Sequential)]
public partial struct DESIGNVECTOR
{
    public uint dvReserved;
    public uint dvNumAxes;
    public InlineArrayInt3216 dvValues;
}
