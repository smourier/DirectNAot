namespace DirectN;

[GeneratedComInterface, Guid("A0928F38-F7D5-44DD-A5C9-E23D94734BBB")]
public partial interface ID2D1DeviceContextLease
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetD2DDeviceContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContext>))] out ID2D1DeviceContext deviceContext);
}
