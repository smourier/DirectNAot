#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("458e1fd1-b1b2-4750-a6e1-9c10f03bed92")]
public partial interface IDxcValidator2 : IDxcValidator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ValidateWithDebug(IDxcBlob pShader, uint Flags, nint /* optional DxcBuffer* */ pOptDebugBitcode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcOperationResult>))] out IDxcOperationResult ppResult);
}
