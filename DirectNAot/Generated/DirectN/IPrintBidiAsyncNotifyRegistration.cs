namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IPrintBidiAsyncNotifyRegistration : IPrintAsyncNotifyRegistration
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AsyncGetNewChannel(IPrintAsyncNewChannelCookie param0);
}
