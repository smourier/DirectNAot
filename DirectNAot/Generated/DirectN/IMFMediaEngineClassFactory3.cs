namespace DirectN;

[GeneratedComInterface, Guid("3787614f-65f7-4003-b673-ead8293a0e60")]
public partial interface IMFMediaEngineClassFactory3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaKeySystemAccess(BSTR keySystem, in IPropertyStore ppSupportedConfigurationsArray, uint uSize, out IMFMediaKeySystemAccess ppKeyAccess);
}
