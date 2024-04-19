namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamgraphstreams
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("632105fa-072e-11d3-8af9-00c04fb6bd3d")]
public partial interface IAMGraphStreams
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamgraphstreams-findupstreaminterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindUpstreamInterface(IPin pPin, in Guid riid, out nint ppvInterface, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamgraphstreams-syncusingstreamoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SyncUsingStreamOffset([MarshalAs(UnmanagedType.U4)] bool bUseStreamOffset);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamgraphstreams-setmaxgraphlatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxGraphLatency(long rtMaxGraphLatency);
}
