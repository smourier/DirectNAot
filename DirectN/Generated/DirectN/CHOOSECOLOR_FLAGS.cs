#nullable enable
namespace DirectN;

[Flags]
public enum CHOOSECOLOR_FLAGS : uint
{
    CC_RGBINIT = 1,
    CC_FULLOPEN = 2,
    CC_PREVENTFULLOPEN = 4,
    CC_SHOWHELP = 8,
    CC_ENABLEHOOK = 16,
    CC_ENABLETEMPLATE = 32,
    CC_ENABLETEMPLATEHANDLE = 64,
    CC_SOLIDCOLOR = 128,
    CC_ANYCOLOR = 256,
}
