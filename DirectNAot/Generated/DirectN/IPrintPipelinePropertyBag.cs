namespace DirectN;

[GeneratedComInterface, Guid("8b8c99dc-7892-4a95-8a04-57422e9fbb47")]
public partial interface IPrintPipelinePropertyBag
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddProperty(PWSTR pszName, in VARIANT pVar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetProperty(PWSTR pszName, out VARIANT pVar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool DeleteProperty(PWSTR pszName);
}
