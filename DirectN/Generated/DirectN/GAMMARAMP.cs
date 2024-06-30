#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-gammaramp
public partial struct GAMMARAMP
{
    public InlineArrayUInt16_256 Red;
    public InlineArrayUInt16_256 Green;
    public InlineArrayUInt16_256 Blue;
}
