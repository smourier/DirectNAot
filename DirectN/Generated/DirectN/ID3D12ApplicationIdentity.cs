#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("82dc6c85-727b-4a8d-9169-db6ce3e975a0")]
public partial interface ID3D12ApplicationIdentity
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationIdentity(in D3D12_APPLICATION_DESC pDesc, in Guid AppId);
}
