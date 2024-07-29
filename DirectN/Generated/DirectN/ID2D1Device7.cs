#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f07c8968-dd4e-4ba6-9cbd-eb6d3752dcbb")]
public partial interface ID2D1Device7 : ID2D1Device6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContext7>))] out ID2D1DeviceContext7 deviceContext);
}
