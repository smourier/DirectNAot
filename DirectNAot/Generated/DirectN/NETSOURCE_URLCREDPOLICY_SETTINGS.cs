#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/ne-wmsinternaladminnetsource-netsource_urlcredpolicy_settings
public enum NETSOURCE_URLCREDPOLICY_SETTINGS
{
    NETSOURCE_URLCREDPOLICY_SETTING_SILENTLOGONOK = 0,
    NETSOURCE_URLCREDPOLICY_SETTING_MUSTPROMPTUSER = 1,
    NETSOURCE_URLCREDPOLICY_SETTING_ANONYMOUSONLY = 2,
}
