#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5981cca4-e8ae-44ca-9b92-4fa86f5a3a3a")]
public partial interface ID3D12CompilerStateObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCompiler(in Guid riid, out nint /* void */ ppCompiler);
}
