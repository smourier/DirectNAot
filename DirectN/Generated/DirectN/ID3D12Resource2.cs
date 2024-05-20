#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("be36ec3b-ea85-4aeb-a45a-e9d76404a495")]
public partial interface ID3D12Resource2 : ID3D12Resource1
{
    [PreserveSig]
    D3D12_RESOURCE_DESC1 GetDesc1();
}
