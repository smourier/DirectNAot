namespace DirectN;

[GeneratedComInterface, Guid("f222ca9f-9968-4db9-81bd-abaebf15f93f")]
public partial interface IFixedDocument
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUri(out BSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintTicket(out IPartPrintTicket ppPrintTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrintTicket(IPartPrintTicket pPrintTicket);
}
