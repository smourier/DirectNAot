#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipersistpropertybag
[GeneratedComInterface, Guid("37d84f60-42cb-11ce-8135-00aa004bb851")]
public partial interface IPersistPropertyBag : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersistpropertybag-initnew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitNew();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersistpropertybag-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyBag>))] IPropertyBag pPropBag, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IErrorLog>))] IErrorLog pErrorLog);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipersistpropertybag-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyBag>))] IPropertyBag pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties);
}
