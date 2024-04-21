namespace DirectN;

[GeneratedComInterface, Guid("aec63fda-7a97-4944-b35c-6c6df8085cc3")]
public partial interface IMFMediaKeySystemAccess
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaKeys(IPropertyStore? pCdmCustomConfig, out IMFMediaKeys2 ppKeys);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SupportedConfiguration(out IPropertyStore ppSupportedConfiguration);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeySystem(out BSTR pKeySystem);
}
