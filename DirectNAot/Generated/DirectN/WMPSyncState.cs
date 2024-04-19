namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmpsyncstate
public enum WMPSyncState
{
    wmpssUnknown = 0,
    wmpssSynchronizing = 1,
    wmpssStopped = 2,
    wmpssEstimating = 3,
    wmpssLast = 4,
}
