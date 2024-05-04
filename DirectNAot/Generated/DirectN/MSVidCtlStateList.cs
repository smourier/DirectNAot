#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msvidctl/ne-msvidctl-msvidctlstatelist
public enum MSVidCtlStateList
{
    STATE_UNBUILT = -1,
    STATE_STOP = 0,
    STATE_PAUSE = 1,
    STATE_PLAY = 2,
}
