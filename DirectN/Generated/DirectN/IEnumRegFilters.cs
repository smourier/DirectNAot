#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ienumregfilters
[GeneratedComInterface, Guid("56a868a4-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IEnumRegFilters
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumregfilters-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cFilters, [In][Out][MarshalUsing(CountElementName = nameof(cFilters))] REGFILTER[] apRegFilter, nint /* optional uint* */ pcFetched);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumregfilters-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cFilters);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumregfilters-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumregfilters-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumRegFilters>))] out IEnumRegFilters ppEnum);
}
