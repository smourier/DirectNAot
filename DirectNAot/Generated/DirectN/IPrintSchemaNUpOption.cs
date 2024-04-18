namespace DirectN;

[GeneratedComInterface, Guid("1f6342f2-d848-42e3-8995-c10a9ef9a3ba")]
public partial interface IPrintSchemaNUpOption : IPrintSchemaOption
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_PagesPerSheet(out uint pulPagesPerSheet);
}
