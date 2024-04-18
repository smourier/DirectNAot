namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/prnasnot/nn-prnasnot-iprintasyncnotifychannel
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4a5031b1-1f3f-4db0-a462-4530ed8b0451")]
public partial interface IPrintAsyncNotifyChannel
{
    // https://learn.microsoft.com/windows/win32/api/prnasnot/nf-prnasnot-iprintasyncnotifychannel-sendnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendNotification(IPrintAsyncNotifyDataObject pData);
    
    // https://learn.microsoft.com/windows/win32/api/prnasnot/nf-prnasnot-iprintasyncnotifychannel-closechannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CloseChannel(IPrintAsyncNotifyDataObject pData);
}
