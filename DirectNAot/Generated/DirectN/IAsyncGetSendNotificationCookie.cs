namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IAsyncGetSendNotificationCookie : IPrintAsyncCookie
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FinishAsyncCallWithData(IPrintAsyncNotifyDataObject param0, [MarshalAs(UnmanagedType.U4)] bool param1);
}
