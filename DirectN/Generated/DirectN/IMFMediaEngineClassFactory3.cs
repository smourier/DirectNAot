#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3787614f-65f7-4003-b673-ead8293a0e60")]
public partial interface IMFMediaEngineClassFactory3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaKeySystemAccess(BSTR keySystem, [In][MarshalUsing(CountElementName = nameof(uSize))] IPropertyStore[] ppSupportedConfigurationsArray, uint uSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaKeySystemAccess>))] out IMFMediaKeySystemAccess ppKeyAccess);
}
