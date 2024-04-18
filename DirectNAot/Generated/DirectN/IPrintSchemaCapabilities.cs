namespace DirectN;

[GeneratedComInterface, Guid("5a577640-501d-4927-bcd0-5ef57a7ed175")]
public partial interface IPrintSchemaCapabilities : IPrintSchemaElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFeatureByKeyName(BSTR bstrKeyName, out IPrintSchemaFeature ppFeature);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFeature(BSTR bstrName, BSTR bstrNamespaceUri, out IPrintSchemaFeature ppFeature);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_PageImageableSize(out IPrintSchemaPageImageableSize ppPageImageableSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_JobCopiesAllDocumentsMinValue(out uint pulJobCopiesAllDocumentsMinValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_JobCopiesAllDocumentsMaxValue(out uint pulJobCopiesAllDocumentsMaxValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSelectedOptionInPrintTicket(IPrintSchemaFeature pFeature, out IPrintSchemaOption ppOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptions(IPrintSchemaFeature pFeature, out IPrintSchemaOptionCollection ppOptionCollection);
}
