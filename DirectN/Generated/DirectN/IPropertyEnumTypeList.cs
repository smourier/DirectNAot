#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertyenumtypelist
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a99400f4-3d84-4557-94ba-1242fb2cc9a6")]
public partial interface IPropertyEnumTypeList
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtypelist-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pctypes);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtypelist-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint itype, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtypelist-getconditionat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConditionAt(uint nIndex, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertyenumtypelist-findmatchingindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindMatchingIndex(in PROPVARIANT propvarCmp, out uint pnIndex);
}
