#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f5b066f0-648a-4611-bd41-27fd0948b9eb")]
public partial interface ID3D12StateObjectDatabaseFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStateObjectDatabaseFromFile(PWSTR pDatabaseFile, D3D12_STATE_OBJECT_DATABASE_FLAGS flags, in Guid riid, out nint /* void */ ppvStateObjectDatabase);
}
