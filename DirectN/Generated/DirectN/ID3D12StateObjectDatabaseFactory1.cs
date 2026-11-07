#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("68a6585d-0ac7-4fa4-ba33-e3bd442f2833")]
public partial interface ID3D12StateObjectDatabaseFactory1 : ID3D12StateObjectDatabaseFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStateObjectDatabaseFromFile1(PWSTR pDatabaseFile, in D3D12_STATE_OBJECT_DATABASE_DESC pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12InfoQueue?>))] ID3D12InfoQueue? pInfoQueue, in Guid riid, out nint /* void */ ppvStateObjectDatabase);
}
