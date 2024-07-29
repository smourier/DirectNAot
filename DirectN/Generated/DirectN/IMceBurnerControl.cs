#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5a86b91a-e71e-46c1-88a9-9bb338710552")]
public partial interface IMceBurnerControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBurnerNoDecryption();
}
