#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifiltermapper2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b79bb0b0-33c1-11d1-abe1-00a0c905f375")]
public partial interface IFilterMapper2
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper2-createcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCategory(in Guid clsidCategory, uint dwCategoryMerit, PWSTR Description);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper2-unregisterfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterFilter(in Guid pclsidCategory, PWSTR szInstance, in Guid Filter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper2-registerfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterFilter(in Guid clsidFilter, PWSTR Name, nint /* optional IMoniker* */ ppMoniker, in Guid pclsidCategory, PWSTR szInstance, in REGFILTER2 prf2);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper2-enummatchingfilters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMatchingFilters([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMoniker>))] out IEnumMoniker ppEnum, uint dwFlags, BOOL bExactMatch, uint dwMerit, BOOL bInputNeeded, uint cInputTypes, nint /* optional Guid* */ pInputTypes, nint /* optional REGPINMEDIUM* */ pMedIn, nint /* optional Guid* */ pPinCategoryIn, BOOL bRender, BOOL bOutputNeeded, uint cOutputTypes, nint /* optional Guid* */ pOutputTypes, nint /* optional REGPINMEDIUM* */ pMedOut, nint /* optional Guid* */ pPinCategoryOut);
}
