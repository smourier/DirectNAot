#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/comsvcs/nn-comsvcs-isharedpropertygroup
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("2a005c07-a5de-11cf-9e66-00aa00a3f464")]
public partial interface ISharedPropertyGroup : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedpropertygroup-createpropertybyposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePropertyByPosition(int Index, out VARIANT_BOOL fExists, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISharedProperty>))] out ISharedProperty ppProp);
    
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedpropertygroup-get_propertybyposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PropertyByPosition(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISharedProperty>))] out ISharedProperty ppProperty);
    
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedpropertygroup-createproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateProperty(BSTR Name, out VARIANT_BOOL fExists, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISharedProperty>))] out ISharedProperty ppProp);
    
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedpropertygroup-get_property
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Property(BSTR Name, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISharedProperty>))] out ISharedProperty ppProperty);
}
