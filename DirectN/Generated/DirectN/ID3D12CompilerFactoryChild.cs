#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e0d06420-9f31-47e8-ae9a-dd2ba25ac0bc")]
public partial interface ID3D12CompilerFactoryChild
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFactory(in Guid riid, out nint /* void */ ppCompilerFactory);
}
