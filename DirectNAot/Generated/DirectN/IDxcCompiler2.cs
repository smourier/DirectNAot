namespace DirectN;

[GeneratedComInterface, Guid("a005a9d9-b8bb-4594-b5c9-0e633bec4d37")]
public partial interface IDxcCompiler2 : IDxcCompiler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileWithDebug(IDxcBlob pSource, PWSTR pSourceName, PWSTR pEntryPoint, PWSTR pTargetProfile, nint /* optional PWSTR */ pArguments, uint argCount, in DxcDefine pDefines, uint defineCount, IDxcIncludeHandler pIncludeHandler, out IDxcOperationResult ppResult, nint /* optional PWSTR */ ppDebugBlobName, nint /* optional IDxcBlob */ ppDebugBlob);
}
