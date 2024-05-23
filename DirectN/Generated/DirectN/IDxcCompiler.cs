#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8c210bf3-011f-4422-8d70-6f9acb8db617")]
public partial interface IDxcCompiler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compile(IDxcBlob pSource, PWSTR pSourceName, PWSTR pEntryPoint, PWSTR pTargetProfile, nint /* optional PWSTR* */ pArguments, uint argCount, [In][MarshalUsing(CountElementName = nameof(defineCount))] DxcDefine[] pDefines, uint defineCount, IDxcIncludeHandler? pIncludeHandler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcOperationResult>))] out IDxcOperationResult ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Preprocess(IDxcBlob pSource, PWSTR pSourceName, nint /* optional PWSTR* */ pArguments, uint argCount, [In][MarshalUsing(CountElementName = nameof(defineCount))] DxcDefine[] pDefines, uint defineCount, IDxcIncludeHandler? pIncludeHandler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcOperationResult>))] out IDxcOperationResult ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disassemble(IDxcBlob pSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding ppDisassembly);
}
