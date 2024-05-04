#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8aaf9303-ad25-48b9-9a57-d9c37e009d9f")]
public partial interface ID3D12SDKConfiguration1 : ID3D12SDKConfiguration
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceFactory(uint SDKVersion, PSTR SDKPath, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvFactory);
    
    [PreserveSig]
    void FreeUnusedSDKs();
}
