#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifiltergraph2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("36b73882-c2c8-11cf-8b46-00805f6cef60")]
public partial interface IFilterGraph2 : IGraphBuilder
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph2-addsourcefilterformoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSourceFilterForMoniker(IMoniker pMoniker, IBindCtx pCtx, PWSTR lpcwstrFilterName, out IBaseFilter ppFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph2-reconnectex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReconnectEx(IPin ppin, nint /* optional AM_MEDIA_TYPE* */ pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph2-renderex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderEx(IPin pPinOut, uint dwFlags, nint /* optional uint* */ pvContext);
}
