namespace DirectN;

[GeneratedComInterface, Guid("572f7389-2168-49e3-9693-d6df5871bf6d")]
public partial interface ID3D12Heap1 : ID3D12Heap
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectedResourceSession(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object? /* void */ ppProtectedSession);
}
