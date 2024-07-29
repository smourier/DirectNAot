#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iqualitycontrol
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868a5-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IQualityControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iqualitycontrol-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(IBaseFilter pSelf, Quality q);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iqualitycontrol-setsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSink(IQualityControl piqc);
}
