#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b81ff171-20f3-11d2-8dcc-00a0c9b00522")]
public partial interface ITypeName
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNameCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNames(uint count, out BSTR rgbszNames, out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeArgumentCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeArguments(uint count, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeName>))] out ITypeName rgpArguments, out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModifierLength(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModifiers(uint count, out uint rgModifiers, out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAssemblyName(out BSTR rgbszAssemblyNames);
}
