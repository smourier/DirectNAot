namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpsyncdevice3
[GeneratedComInterface, Guid("b22c85f9-263c-4372-a0da-b518db9b4098")]
public partial interface IWMPSyncDevice3 : IWMPSyncDevice2
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice3-estimatesyncsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT estimateSyncSize(IWMPPlaylist pNonRulePlaylist, IWMPPlaylist pRulesPlaylist);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice3-cancelestimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT cancelEstimation();
}
