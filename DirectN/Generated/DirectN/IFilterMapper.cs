#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifiltermapper
[GeneratedComInterface, Guid("56a868a3-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IFilterMapper
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-registerfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterFilter(Guid clsid, PWSTR Name, uint dwMerit);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-registerfilterinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterFilterInstance(Guid clsid, PWSTR Name, out Guid MRId);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-registerpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterPin(Guid Filter, PWSTR Name, BOOL bRendered, BOOL bOutput, BOOL bZero, BOOL bMany, Guid ConnectsToFilter, PWSTR ConnectsToPin);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-registerpintype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterPinType(Guid clsFilter, PWSTR strName, Guid clsMajorType, Guid clsSubType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-unregisterfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterFilter(Guid Filter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-unregisterfilterinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterFilterInstance(Guid MRId);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-unregisterpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterPin(Guid Filter, PWSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltermapper-enummatchingfilters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMatchingFilters([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumRegFilters>))] out IEnumRegFilters ppEnum, uint dwMerit, BOOL bInputNeeded, Guid clsInMaj, Guid clsInSub, BOOL bRender, BOOL bOututNeeded, Guid clsOutMaj, Guid clsOutSub);
}
