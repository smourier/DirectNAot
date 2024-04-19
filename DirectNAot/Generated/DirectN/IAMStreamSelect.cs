namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamstreamselect
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c1960960-17f5-11d1-abe1-00a0c905f375")]
public partial interface IAMStreamSelect
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamselect-count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Count(out uint pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamselect-info
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Info(int lIndex, nint/* nint */ ppmt, nint/* nint */ pdwFlags, nint/* nint */ plcid, nint/* nint */ pdwGroup, nint/* nint */ ppszName, nint/* nint */ ppObject, nint/* nint */ ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamselect-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable(int lIndex, uint dwFlags);
}
