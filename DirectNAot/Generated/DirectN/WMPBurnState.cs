namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmpburnstate
public enum WMPBurnState
{
    wmpbsUnknown = 0,
    wmpbsBusy = 1,
    wmpbsReady = 2,
    wmpbsWaitingForDisc = 3,
    wmpbsRefreshStatusPending = 4,
    wmpbsPreparingToBurn = 5,
    wmpbsBurning = 6,
    wmpbsStopped = 7,
    wmpbsErasing = 8,
    wmpbsDownloading = 9,
}
