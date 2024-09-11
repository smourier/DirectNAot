#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12lifetimetracker
[GeneratedComInterface, Guid("3fd03d36-4eb1-424a-a582-494ecb8ba813")]
public partial interface ID3D12LifetimeTracker : ID3D12DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12lifetimetracker-destroyownedobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DestroyOwnedObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12DeviceChild>))] ID3D12DeviceChild pObject);
}
