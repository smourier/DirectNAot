#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("6a6ffad8-78b6-473d-b844-98152e4fb16b")]
public partial interface ISpCFGInterpreterSite
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTextReplacement(in SPPHRASEREPLACEMENT pReplace);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddProperty(in SPPHRASEPROPERTY pProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceValue(PWSTR pszResourceName, out PWSTR ppCoMemResource);
}
