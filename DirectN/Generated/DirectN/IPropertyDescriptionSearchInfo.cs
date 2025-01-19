#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertydescriptionsearchinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("078f91bd-29a2-440f-924e-46a291524520")]
public partial interface IPropertyDescriptionSearchInfo : IPropertyDescription
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionsearchinfo-getsearchinfoflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSearchInfoFlags(out PROPDESC_SEARCHINFO_FLAGS ppdsiFlags);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionsearchinfo-getcolumnindextype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumnIndexType(out PROPDESC_COLUMNINDEX_TYPE ppdciType);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionsearchinfo-getprojectionstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProjectionString(out PWSTR ppszProjection);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertydescriptionsearchinfo-getmaxsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxSize(out uint pcbMaxSize);
}
