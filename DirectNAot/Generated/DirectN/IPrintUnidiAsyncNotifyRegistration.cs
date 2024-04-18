namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IPrintUnidiAsyncNotifyRegistration : IPrintAsyncNotifyRegistration
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AsyncGetNotification(IAsyncGetSendNotificationCookie param0);
}
