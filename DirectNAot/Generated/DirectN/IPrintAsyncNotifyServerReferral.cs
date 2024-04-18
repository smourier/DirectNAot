namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IPrintAsyncNotifyServerReferral
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetServerReferral(out PWSTR param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AsyncGetServerReferral(IAsyncGetSrvReferralCookie param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetServerReferral(PWSTR pRmtServerReferral);
}
