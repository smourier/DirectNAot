#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a005a9d9-b8bb-4594-b5c9-0e633bec4d37")]
public partial interface IDxcCompiler2 : IDxcCompiler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileWithDebug([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pSource, PWSTR pSourceName, PWSTR pEntryPoint, PWSTR pTargetProfile, nint /* optional PWSTR* */ pArguments, uint argCount, [In][MarshalUsing(CountElementName = nameof(defineCount))] DxcDefine[] pDefines, uint defineCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcIncludeHandler?>))] IDxcIncludeHandler? pIncludeHandler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcOperationResult>))] out IDxcOperationResult ppResult, nint /* optional PWSTR* */ ppDebugBlobName, nint /* optional IDxcBlob* */ ppDebugBlob);
}
