#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertydescription
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6f79d558-3e96-4549-a1d1-7d75d2288814")]
public partial interface IPropertyDescription
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getpropertykey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyKey(out PROPERTYKEY pkey);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getcanonicalname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCanonicalName(out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getpropertytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyType(out ushort pvartype);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayName(out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-geteditinvitation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEditInvitation(out PWSTR ppszInvite);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-gettypeflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeFlags(PROPDESC_TYPE_FLAGS mask, out PROPDESC_TYPE_FLAGS ppdtFlags);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getviewflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewFlags(out PROPDESC_VIEW_FLAGS ppdvFlags);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getdefaultcolumnwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultColumnWidth(out uint pcxChars);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getdisplaytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayType(out PROPDESC_DISPLAYTYPE pdisplaytype);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getcolumnstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumnState(out uint pcsFlags);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getgroupingrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupingRange(out PROPDESC_GROUPING_RANGE pgr);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getrelativedescriptiontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelativeDescriptionType(out PROPDESC_RELATIVEDESCRIPTION_TYPE prdt);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getrelativedescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelativeDescription(in PROPVARIANT propvar1, in PROPVARIANT propvar2, out PWSTR ppszDesc1, out PWSTR ppszDesc2);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getsortdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSortDescription(out PROPDESC_SORTDESCRIPTION psd);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getsortdescriptionlabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSortDescriptionLabel(BOOL fDescending, out PWSTR ppszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getaggregationtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAggregationType(out PROPDESC_AGGREGATION_TYPE paggtype);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getconditiontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConditionType(out PROPDESC_CONDITION_TYPE pcontype, out CONDITION_OPERATION popDefault);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-getenumtypelist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumTypeList(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-coercetocanonicalvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CoerceToCanonicalValue(ref PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-formatfordisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FormatForDisplay(in PROPVARIANT propvar, PROPDESC_FORMAT_FLAGS pdfFlags, out PWSTR ppszDisplay);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescription-isvaluecanonical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsValueCanonical(in PROPVARIANT propvar);
}
