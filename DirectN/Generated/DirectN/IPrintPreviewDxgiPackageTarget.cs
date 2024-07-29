#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1a6dd0ad-1e2a-4e99-a5ba-91f17818290e")]
public partial interface IPrintPreviewDxgiPackageTarget
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetJobPageCount(PageCountType countType, uint count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawPage(uint jobPageNumber, IDXGISurface pageImage, float dpiX, float dpiY);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvalidatePreview();
}
