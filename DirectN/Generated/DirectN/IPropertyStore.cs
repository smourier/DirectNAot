#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertystore
[GeneratedComInterface, Guid("886d8eeb-8cf2-4446-8d02-cdba1dbdcf99")]
public partial interface IPropertyStore
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint cProps);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint iProp, out PROPERTYKEY pkey);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(in PROPERTYKEY key, out PROPVARIANT pv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-setvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(in PROPERTYKEY key, in PROPVARIANT propvar);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystore-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
}
