namespace DirectN;

[GeneratedComInterface, Guid("532818f7-921b-4fb2-bff8-2f4fd52ebebf")]
public partial interface IBidiAsyncNotifyChannel : IPrintAsyncNotifyChannel
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateNotificationChannel();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintName(in IPrintAsyncNotifyDataObject param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetChannelNotificationType(in IPrintAsyncNotifyDataObject param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AsyncGetNotificationSendResponse(IPrintAsyncNotifyDataObject param0, IAsyncGetSendNotificationCookie param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AsyncCloseChannel(IPrintAsyncNotifyDataObject param0, IPrintAsyncCookie param1);
}
