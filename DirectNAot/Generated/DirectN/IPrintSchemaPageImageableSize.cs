namespace DirectN;

[GeneratedComInterface, Guid("7c85bf5e-dc7c-4f61-839b-4107e1c9b68e")]
public partial interface IPrintSchemaPageImageableSize : IPrintSchemaElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_ImageableSizeWidthInMicrons(out uint pulImageableSizeWidth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_ImageableSizeHeightInMicrons(out uint pulImageableSizeHeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_OriginWidthInMicrons(out uint pulOriginWidth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_OriginHeightInMicrons(out uint pulOriginHeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_ExtentWidthInMicrons(out uint pulExtentWidth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_ExtentHeightInMicrons(out uint pulExtentHeight);
}
