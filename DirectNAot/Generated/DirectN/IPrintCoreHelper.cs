namespace DirectN;

[GeneratedComInterface, Guid("a89ec53e-3905-49c6-9c1a-c0a88117fdb6")]
public partial interface IPrintCoreHelper
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOption(nint/* nint */ pDevmode, uint cbSize, PSTR pszFeatureRequested, out PSTR ppszOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOptions(ref DEVMODEA pDevmode, uint cbSize, [MarshalAs(UnmanagedType.U4)] bool bResolveConflicts, in PRINT_FEATURE_OPTION pFOPairs, uint cPairs, ref uint pcPairsWritten, ref uint pdwResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumConstrainedOptions(in DEVMODEA pDevmode, uint cbSize, PSTR pszFeatureKeyword, in PSTR pConstrainedOptionList, ref uint pdwNumOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WhyConstrained(nint/* nint */ pDevmode, uint cbSize, PSTR pszFeatureKeyword, PSTR pszOptionKeyword, out PRINT_FEATURE_OPTION ppFOConstraints, out uint pdwNumOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumFeatures(out PSTR pFeatureList, out uint pdwNumFeatures);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumOptions(PSTR pszFeatureKeyword, out PSTR pOptionList, out uint pdwNumOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontSubstitution(PWSTR pszTrueTypeFontName, in PWSTR ppszDevFontName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFontSubstitution(PWSTR pszTrueTypeFontName, PWSTR pszDevFontName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInstanceOfMSXMLObject(in Guid rclsid, nint pUnkOuter, uint dwClsContext, in Guid riid, out nint ppv);
}
