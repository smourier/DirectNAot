namespace DirectN;

[GeneratedComInterface, Guid("0f6f27b6-6f86-4591-9203-64c3bfadedfe")]
public partial interface IPrintAsyncNotifyRegistration
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterForNotifications();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnregisterForNotifications();
}
