#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-psinjectdata
public partial struct PSINJECTDATA
{
    public uint DataBytes;
    public PSINJECT_POINT InjectionPoint;
    public ushort PageNumber;
}
