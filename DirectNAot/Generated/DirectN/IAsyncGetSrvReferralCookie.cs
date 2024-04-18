namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IAsyncGetSrvReferralCookie
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FinishAsyncCall([MarshalAs(UnmanagedType.Error)] HRESULT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CancelAsyncCall([MarshalAs(UnmanagedType.Error)] HRESULT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FinishAsyncCallWithData(PWSTR param0);
}
