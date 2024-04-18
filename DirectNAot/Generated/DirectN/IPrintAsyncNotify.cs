namespace DirectN;

[GeneratedComInterface, Guid("532818f7-921b-4fb2-bff8-2f4fd52ebebf")]
public partial interface IPrintAsyncNotify
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePrintAsyncNotifyChannel(uint param0, in Guid param1, PrintAsyncNotifyUserFilter param2, PrintAsyncNotifyConversationStyle param3, IPrintAsyncNotifyCallback param4, out IPrintAsyncNotifyChannel param5);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePrintAsyncNotifyRegistration(in Guid param0, PrintAsyncNotifyUserFilter param1, PrintAsyncNotifyConversationStyle param2, IPrintAsyncNotifyCallback param3, out IPrintAsyncNotifyRegistration param4);
}
