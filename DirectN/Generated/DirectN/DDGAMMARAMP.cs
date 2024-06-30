#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddgammaramp
public partial struct DDGAMMARAMP
{
    public InlineArrayUInt16_256 red;
    public InlineArrayUInt16_256 green;
    public InlineArrayUInt16_256 blue;
}
