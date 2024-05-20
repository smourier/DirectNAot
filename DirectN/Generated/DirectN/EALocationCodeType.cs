#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface_enums/ns-bdaiface_enums-ealocationcodetype
[StructLayout(LayoutKind.Sequential)]
public partial struct EALocationCodeType
{
    public LocationCodeSchemeType LocationCodeScheme;
    public byte state_code;
    public byte county_subdivision;
    public ushort county_code;
}
