namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_4/nn-d3d11_4-id3d11device5
[GeneratedComInterface, Guid("8ffde202-a0e7-45df-9e01-e837801b5ea0")]
public partial interface ID3D11Device5 : ID3D11Device4
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11device5-opensharedfence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenSharedFence(HANDLE hFence, in Guid ReturnedInterface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object? /* void */ ppFence);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11device5-createfence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFence(ulong InitialValue, D3D11_FENCE_FLAG Flags, in Guid ReturnedInterface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object? /* void */ ppFence);
}
