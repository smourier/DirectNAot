namespace DirectN;

[GeneratedComInterface, Guid("4d07fc10-f931-11ce-b001-00aa006884e5")]
public partial interface ICategorizeProperties
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapPropertyToCategory(DISPID dispid, out PROPCAT ppropcat);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategoryName(PROPCAT propcat, uint lcid, out BSTR pbstrName);
}
