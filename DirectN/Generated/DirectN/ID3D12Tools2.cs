#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("01d393c5-c9b0-42a1-958c-c26b02d4d097")]
public partial interface ID3D12Tools2 : ID3D12Tools1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationSpecificDriverState(nint pAdapter, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob?>))] ID3DBlob? pBlob);
}
