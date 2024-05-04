#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mf_plugin_type
public enum MF_Plugin_Type
{
    MF_Plugin_Type_MFT = 0,
    MF_Plugin_Type_MediaSource = 1,
    MF_Plugin_Type_MFT_MatchOutputType = 2,
    MF_Plugin_Type_Other = -1,
}
