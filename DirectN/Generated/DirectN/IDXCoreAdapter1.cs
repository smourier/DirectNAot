#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a0783366-cfa3-43be-9d79-55b2da97c63c")]
public partial interface IDXCoreAdapter1 : IDXCoreAdapter
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyWithInput(DXCoreAdapterProperty property, nuint inputPropertyDetailsSize, nint /* optional void* */ inputPropertyDetails, nuint outputBufferSize, nint outputBuffer);
}
