namespace DirectN;

[GeneratedComInterface, Guid("454A82A1-F024-40DB-BD5B-8F527FD58AD0")]
public partial interface ID2D1DeviceContextPool
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceContextLease([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContextLease>))] out ID2D1DeviceContextLease lease);
}
