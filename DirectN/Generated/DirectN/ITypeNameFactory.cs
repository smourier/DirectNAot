#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b81ff171-20f3-11d2-8dcc-00a0c9b00521")]
public partial interface ITypeNameFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseTypeName(PWSTR szName, out uint pError, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeName>))] out ITypeName ppTypeName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeNameBuilder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeNameBuilder>))] out ITypeNameBuilder ppTypeBuilder);
}
