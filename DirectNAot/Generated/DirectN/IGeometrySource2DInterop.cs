namespace DirectN;

[GeneratedComInterface, Guid("0657af73-53fd-47cf-84ff-c8492d2a80a3")]
public partial interface IGeometrySource2DInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGeometry(out ID2D1Geometry value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryGetGeometryUsingFactory(ID2D1Factory factory, out ID2D1Geometry value);
}
