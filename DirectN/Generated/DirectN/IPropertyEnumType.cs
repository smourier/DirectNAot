#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertyenumtype
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("11e1fbf9-2d56-4a6b-8db3-7cd193a471f2")]
public partial interface IPropertyEnumType
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtype-getenumtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumType(out PROPENUMTYPE penumtype);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtype-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtype-getrangeminvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRangeMinValue(out PROPVARIANT ppropvarMin);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtype-getrangesetvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRangeSetValue(out PROPVARIANT ppropvarSet);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtype-getdisplaytext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayText(out PWSTR ppszDisplay);
}
