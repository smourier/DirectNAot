namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iamnetworkstatus
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fa2aa8f3-8b62-11d0-a520-000000000000")]
public partial interface IAMNetworkStatus : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetworkstatus-get_receivedpackets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReceivedPackets(ref int pReceivedPackets);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetworkstatus-get_recoveredpackets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecoveredPackets(ref int pRecoveredPackets);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetworkstatus-get_lostpackets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LostPackets(ref int pLostPackets);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetworkstatus-get_receptionquality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReceptionQuality(ref int pReceptionQuality);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetworkstatus-get_bufferingcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BufferingCount(ref int pBufferingCount);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetworkstatus-get_isbroadcast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsBroadcast(ref VARIANT_BOOL pIsBroadcast);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetworkstatus-get_bufferingprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BufferingProgress(ref int pBufferingProgress);
}
