namespace DirectN;

[GeneratedComInterface, Guid("68746729-f493-4830-a10f-69028774605d")]
public partial interface IPrintSchemaPageMediaSizeOption : IPrintSchemaOption
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_WidthInMicrons(out uint pulWidth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_HeightInMicrons(out uint pulHeight);
}
