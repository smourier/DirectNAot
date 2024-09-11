#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("228b4687-5a6a-4730-900c-9702b2203f54")]
public partial interface IDxcCompiler3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compile(in DxcBuffer pSource, nint /* optional PWSTR* */ pArguments, uint argCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcIncludeHandler?>))] IDxcIncludeHandler? pIncludeHandler, in Guid riid, out nint /* void */ ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disassemble(in DxcBuffer pObject, in Guid riid, out nint /* void */ ppResult);
}
