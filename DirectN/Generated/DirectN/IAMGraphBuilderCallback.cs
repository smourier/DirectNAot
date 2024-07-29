#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamgraphbuildercallback
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("4995f511-9ddb-4f12-bd3b-f04611807b79")]
public partial interface IAMGraphBuilderCallback
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamgraphbuildercallback-selectedfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectedFilter(IMoniker pMon);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamgraphbuildercallback-createdfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatedFilter(IBaseFilter pFil);
}
