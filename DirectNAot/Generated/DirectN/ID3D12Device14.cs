#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5f6e592d-d895-44c2-8e4a-88ad4926d323")]
public partial interface ID3D12Device14 : ID3D12Device13
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRootSignatureFromSubobjectInLibrary(uint nodeMask, nint pLibraryBlob, nuint blobLengthInBytes, PWSTR subobjectName, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvRootSignature);
}
