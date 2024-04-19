namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmpfolderscanstate
public enum WMPFolderScanState
{
    wmpfssUnknown = 0,
    wmpfssScanning = 1,
    wmpfssUpdating = 2,
    wmpfssStopped = 3,
}
