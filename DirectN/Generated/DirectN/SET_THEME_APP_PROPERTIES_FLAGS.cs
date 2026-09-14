#nullable enable
namespace DirectN;

[Flags]
public enum SET_THEME_APP_PROPERTIES_FLAGS : uint
{
    ALLOW_NONCLIENT = 1,
    ALLOW_CONTROLS = 2,
    ALLOW_WEBCONTENT = 4,
    VALIDBITS = 7,
}
