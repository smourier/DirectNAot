#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c99af463-d629-4ec4-8c00-e54d68154248")]
public partial interface IKsJackContainerId
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackContainerId(out Guid pJackContainerId);
}
