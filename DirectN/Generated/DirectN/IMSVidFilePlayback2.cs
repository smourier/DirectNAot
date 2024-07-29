#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidfileplayback2
[GeneratedComInterface, Guid("2f7e44af-6e52-4660-bc08-d8d542587d72")]
public partial interface IMSVidFilePlayback2 : IMSVidFilePlayback
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfileplayback2-put__sourcefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__SourceFilter(BSTR FileName);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfileplayback2-put___sourcefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put___SourceFilter(Guid FileName);
}
