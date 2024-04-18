namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IPrintAsyncNewChannelCookie : IPrintAsyncCookie
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FinishAsyncCallWithData(in IPrintAsyncNotifyChannel param0, uint param1);
}
