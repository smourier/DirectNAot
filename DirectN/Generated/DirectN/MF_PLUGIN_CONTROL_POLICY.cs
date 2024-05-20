#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mf_plugin_control_policy
public enum MF_PLUGIN_CONTROL_POLICY
{
    MF_PLUGIN_CONTROL_POLICY_USE_ALL_PLUGINS = 0,
    MF_PLUGIN_CONTROL_POLICY_USE_APPROVED_PLUGINS = 1,
    MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS = 2,
    MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS_EDGEMODE = 3,
}
