namespace DirectN;

[GeneratedComInterface, Guid("e480b861-4708-4e6d-a5b4-a2b4eeb9baa4")]
public partial interface IPrintSchemaTicket : IPrintSchemaElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFeatureByKeyName(BSTR bstrKeyName, out IPrintSchemaFeature ppFeature);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFeature(BSTR bstrName, BSTR bstrNamespaceUri, out IPrintSchemaFeature ppFeature);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ValidateAsync(out IPrintSchemaAsyncOperation ppAsyncOperation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CommitAsync(IPrintSchemaTicket pPrintTicketCommit, out IPrintSchemaAsyncOperation ppAsyncOperation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT NotifyXmlChanged();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCapabilities(out IPrintSchemaCapabilities ppCapabilities);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_JobCopiesAllDocuments(out uint pulJobCopiesAllDocuments);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_JobCopiesAllDocuments(uint ulJobCopiesAllDocuments);
}
