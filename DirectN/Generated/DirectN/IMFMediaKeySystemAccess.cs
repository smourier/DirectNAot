#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("aec63fda-7a97-4944-b35c-6c6df8085cc3")]
public partial interface IMFMediaKeySystemAccess
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaKeys(IPropertyStore? pCdmCustomConfig, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaKeys2>))] out IMFMediaKeys2 ppKeys);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SupportedConfiguration([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore ppSupportedConfiguration);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeySystem(out BSTR pKeySystem);
}
