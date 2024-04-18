namespace DirectN;

[GeneratedComInterface, Guid("c2c14f6f-95d3-4d63-96cf-6bd9e6c907c2")]
public partial interface IPrintCoreHelperPS : IPrintCoreHelper
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGlobalAttribute(PSTR pszAttribute, out uint pdwDataType, out nint /* byte array */ ppbData, out uint pcbSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFeatureAttribute(PSTR pszFeatureKeyword, PSTR pszAttribute, out uint pdwDataType, out nint /* byte array */ ppbData, out uint pcbSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptionAttribute(PSTR pszFeatureKeyword, PSTR pszOptionKeyword, PSTR pszAttribute, out uint pdwDataType, out nint /* byte array */ ppbData, out uint pcbSize);
}
