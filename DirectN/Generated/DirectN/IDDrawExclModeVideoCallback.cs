#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iddrawexclmodevideocallback
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("913c24a0-20ab-11d2-9038-00a0c9697298")]
public partial interface IDDrawExclModeVideoCallback
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideocallback-onupdateoverlay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnUpdateOverlay([MarshalAs(UnmanagedType.U4)] bool bBefore, uint dwFlags, [MarshalAs(UnmanagedType.U4)] bool bOldVisible, in RECT prcOldSrc, in RECT prcOldDest, [MarshalAs(UnmanagedType.U4)] bool bNewVisible, in RECT prcNewSrc, in RECT prcNewDest);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideocallback-onupdatecolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnUpdateColorKey(in COLORKEY pKey, uint dwColor);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideocallback-onupdatesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnUpdateSize(uint dwWidth, uint dwHeight, uint dwARWidth, uint dwARHeight);
}
