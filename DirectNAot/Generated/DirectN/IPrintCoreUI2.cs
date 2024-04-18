namespace DirectN;

[GeneratedComInterface, Guid("085ccfca-3adf-4c9e-b491-d851a6edc997")]
public partial interface IPrintCoreUI2 : IPrintOemDriverUI
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptions(in OEMUIOBJ poemuiobj, uint dwFlags, nint/* nint */ pmszFeaturesRequested, uint cbIn, out PSTR pmszFeatureOptionBuf, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOptions(in OEMUIOBJ poemuiobj, uint dwFlags, in sbyte pmszFeatureOptionBuf, uint cbIn, out uint pdwResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumConstrainedOptions(in OEMUIOBJ poemuiobj, uint dwFlags, PSTR pszFeatureKeyword, out PSTR pmszConstrainedOptionList, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WhyConstrained(in OEMUIOBJ poemuiobj, uint dwFlags, PSTR pszFeatureKeyword, PSTR pszOptionKeyword, out PSTR pmszReasonList, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGlobalAttribute(in OEMUIOBJ poemuiobj, uint dwFlags, PSTR pszAttribute, out uint pdwDataType, nint /* byte array */ pbData, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFeatureAttribute(in OEMUIOBJ poemuiobj, uint dwFlags, PSTR pszFeatureKeyword, PSTR pszAttribute, out uint pdwDataType, nint /* byte array */ pbData, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptionAttribute(in OEMUIOBJ poemuiobj, uint dwFlags, PSTR pszFeatureKeyword, PSTR pszOptionKeyword, PSTR pszAttribute, out uint pdwDataType, nint /* byte array */ pbData, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumFeatures(in OEMUIOBJ poemuiobj, uint dwFlags, out PSTR pmszFeatureList, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumOptions(in OEMUIOBJ poemuiobj, uint dwFlags, PSTR pszFeatureKeyword, out PSTR pmszOptionList, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QuerySimulationSupport(HANDLE hPrinter, uint dwLevel, nint /* byte array */ pCaps, uint cbSize, out uint pcbNeeded);
}
