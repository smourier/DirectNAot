namespace DirectN;

[GeneratedComInterface, Guid("d580dc0e-de39-4649-baa8-bf0b85a03a97")]
public partial interface IBidiSpl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BindDevice(PWSTR pszDeviceName, uint dwAccess);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnbindDevice();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendRecv(PWSTR pszAction, IBidiRequest pRequest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MultiSendRecv(PWSTR pszAction, IBidiRequestContainer pRequestContainer);
}
