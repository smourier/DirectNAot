namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/prnasnot/nn-prnasnot-iprintasyncnotifycallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7def34c1-9d92-4c99-b3b3-db94a9d4191b")]
public partial interface IPrintAsyncNotifyCallback
{
    // https://learn.microsoft.com/windows/win32/api/prnasnot/nf-prnasnot-iprintasyncnotifycallback-oneventnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OnEventNotify(IPrintAsyncNotifyChannel pChannel, IPrintAsyncNotifyDataObject pData);
    
    // https://learn.microsoft.com/windows/win32/api/prnasnot/nf-prnasnot-iprintasyncnotifycallback-channelclosed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ChannelClosed(IPrintAsyncNotifyChannel pChannel, IPrintAsyncNotifyDataObject pData);
}
