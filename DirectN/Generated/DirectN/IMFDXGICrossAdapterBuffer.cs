#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b25d03fb-d148-45ef-bfed-f778b7566c07")]
public partial interface IMFDXGICrossAdapterBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceForDevice(nint pUnkDevice, in Guid riid, out nint /* void */ ppvObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubresourceIndexForDevice(nint pUnkDevice, out uint puSubresource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnknownForDevice(nint pUnkDevice, in Guid guid, in Guid riid, out nint /* void */ ppvObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnknownForDevice(nint pUnkDevice, in Guid guid, nint pUnkData);
}
