namespace DirectN;

[GeneratedComInterface, Guid("8028d181-2c32-4249-8493-1bfb22045574")]
public partial interface IFixedDocumentSequence
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
