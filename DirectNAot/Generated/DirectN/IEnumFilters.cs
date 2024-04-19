namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ienumfilters
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a86893-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IEnumFilters
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumfilters-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cFilters, out IBaseFilter ppFilter, nint/* nint */ pcFetched);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumfilters-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cFilters);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumfilters-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumfilters-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumFilters ppEnum);
}
