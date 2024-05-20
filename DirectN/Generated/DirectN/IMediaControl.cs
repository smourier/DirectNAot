#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-imediacontrol
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b1-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaControl : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(int msTimeout, out int pfs);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-renderfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderFile(BSTR strFilename);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-addsourcefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSourceFilter(BSTR strFilename, out IDispatch ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-get_filtercollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FilterCollection(out IDispatch ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-get_regfiltercollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RegFilterCollection(out IDispatch ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediacontrol-stopwhenready
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopWhenReady();
}
