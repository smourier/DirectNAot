#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-itypecomp
[GeneratedComInterface, Guid("00020403-0000-0000-c000-000000000046")]
public partial interface ITypeComp
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypecomp-bind
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Bind(PWSTR szName, uint lHashVal, ushort wFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeInfo>))] out ITypeInfo ppTInfo, out DESCKIND pDescKind, out BINDPTR pBindPtr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypecomp-bindtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindType(PWSTR szName, uint lHashVal, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeInfo>))] out ITypeInfo ppTInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeComp>))] out ITypeComp ppTComp);
}
